using ClosedXML.Excel;
using ScaleGenerator.Domain.Entities;

namespace ScaleGenerator.Domain.Excel;

public static class ExcelManager
{
    public static void ExportToExcel(Tuple<List<Scale> , DateTime> tuple)
    {
        var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Escalas");

        worksheet.Cell(1 , 1).Value = tuple.Item2.Date.ToString("dd/MM/yyyy");
        worksheet.Cell(2 , 1).Value = "Nome";

        for(int i = 0 ; i < tuple.Item1.Count ; i++)
        {
            worksheet.Cell(i + 2 , 1).Value = tuple.Item1[i].Name;
        }

        string fileName = "Escalas.xlsx";
        string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

        // Se o diretório não existir, crie-o
        if(!Directory.Exists(downloadPath))
        {
            Directory.CreateDirectory(downloadPath);
        }

        // Salve o arquivo
        workbook.SaveAs(fileName);

        // Verifique se o arquivo já existe no diretório de Downloads
        if(!File.Exists(downloadPath + fileName))
        {
            // Copie o arquivo do diretório de trabalho para o diretório de Downloads
            File.Copy(fileName , downloadPath + fileName);
        }
        else
        {
            File.Delete(downloadPath + fileName);
            File.Copy(fileName , downloadPath + fileName);
        }
    }

    public static Tuple<List<Scale> , DateTime> GenerateScales(List<string> scaleNames , int count)
    {
        var random = new Random();
        var scales = new List<Scale>();
        DateTime dateTime = DateTime.Now;
        DayOfWeek scaleDate = DateTime.Now.DayOfWeek;

        switch(scaleDate)
        {
            case DayOfWeek.Sunday:
                dateTime = dateTime.AddDays(6);
                break;
            case DayOfWeek.Monday:
                dateTime = dateTime.AddDays(5);
                break;
            case DayOfWeek.Tuesday:
                dateTime = dateTime.AddDays(4);
                break;
            case DayOfWeek.Wednesday:
                dateTime = dateTime.AddDays(3);
                break;
            case DayOfWeek.Thursday:
                dateTime = dateTime.AddDays(2);
                break;
            case DayOfWeek.Friday:
                dateTime = dateTime.AddDays(1);
                break;

        }

        for(int i = 0 ; i < count ; i++)
        {
            string name = scaleNames[random.Next(scaleNames.Count)];

            if(scales.Where(x => x.Name.Equals(name)).Equals(1))
                continue;

            var scale = new Scale
            {
                Name = name ,
                ScaleDate = dateTime
            };

            scales.Add(scale);
        }

        return Tuple.Create(scales , dateTime);
    }
}
