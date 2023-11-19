using ClosedXML.Excel;
using ScaleGenerator.Domain.Entities;

namespace ScaleGenerator.Domain.Excel;

public sealed class ExcelManager
{
    public void ExportToExcel(List<Scale> scales)
    {
        var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Escalas");

        worksheet.Cell(1 , 1).Value = "Nome";

        for(int i = 0 ; i < scales.Count ; i++)
        {
            worksheet.Cell(i + 2 , 1).Value = scales[i].Name;
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
    }

    public List<Scale> GenerateScales(List<string> scaleNames , int count)
    {
        var random = new Random();
        var scales = new List<Scale>();

        for(int i = 0 ; i < count ; i++)
        {
            var scale = new Scale
            {
                Name = scaleNames[random.Next(scaleNames.Count)] ,
            };

            scales.Add(scale);
        }

        return scales;
    }
}
