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
            var scaleNames = new List<string> { "Scale 1" , "Scale 2" , "Scale 3" };
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
