using ScaleGenerator.Domain.Excel;

namespace ScaleGenerator
{
    public partial class KidsMinistryScale : Form
    {
        public KidsMinistryScale()
        {
            InitializeComponent();
        }

        private void buttonGenerateAndExport_Click(object sender , EventArgs e)
        {
            List<string> scaleNames = new List<string>();
            var names = listNamesScale.Text;

            if(names.Contains("\n"))
            {
                var splitNames = names.Split(new string[] {"\r\n" }, StringSplitOptions.None);

                for(int i = 0 ; i < splitNames.Count() ; i++)
                {
                    scaleNames.Add(splitNames[i]);
                }
            }
            
            var count = 3;

            var excelManager = new ExcelManager();
            excelManager.ExportToExcel(excelManager.GenerateScales(scaleNames , count));

            MessageBox.Show("Escalas geradas e exportadas com sucesso!" , "Sucesso" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender , EventArgs e)
        {

        }
    }
}
