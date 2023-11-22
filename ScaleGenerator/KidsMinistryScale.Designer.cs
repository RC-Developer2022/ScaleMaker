namespace ScaleGenerator;

partial class KidsMinistryScale
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if(disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonGenerateAndExport = new Button();
        listNamesScale = new TextBox();
        dataGridViewScale = new DataGridView();
        ((System.ComponentModel.ISupportInitialize) dataGridViewScale).BeginInit();
        SuspendLayout();
        // 
        // buttonGenerateAndExport
        // 
        buttonGenerateAndExport.Location = new Point(87 , 220);
        buttonGenerateAndExport.Margin = new Padding(4 , 5 , 4 , 5);
        buttonGenerateAndExport.Name = "buttonGenerateAndExport";
        buttonGenerateAndExport.Size = new Size(217 , 35);
        buttonGenerateAndExport.TabIndex = 0;
        buttonGenerateAndExport.Text = "Gerar e Exportar Escalas";
        buttonGenerateAndExport.UseVisualStyleBackColor = true;
        buttonGenerateAndExport.Click += buttonGenerateAndExport_Click;
        // 
        // listNamesScale
        // 
        listNamesScale.Location = new Point(87 , 22);
        listNamesScale.Multiline = true;
        listNamesScale.Name = "listNamesScale";
        listNamesScale.Size = new Size(217 , 177);
        listNamesScale.TabIndex = 1;
        // 
        // dataGridViewScale
        // 
        dataGridViewScale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewScale.Location = new Point(33 , 263);
        dataGridViewScale.Name = "dataGridViewScale";
        dataGridViewScale.RowHeadersWidth = 51;
        dataGridViewScale.Size = new Size(303 , 134);
        dataGridViewScale.TabIndex = 2;
        // 
        // KidsMinistryScale
        // 
        AutoScaleDimensions = new SizeF(8F , 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380 , 426);
        Controls.Add(dataGridViewScale);
        Controls.Add(listNamesScale);
        Controls.Add(buttonGenerateAndExport);
        Margin = new Padding(4 , 5 , 4 , 5);
        Name = "KidsMinistryScale";
        Text = "Formulário Principal";
        ((System.ComponentModel.ISupportInitialize) dataGridViewScale).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion

    private Button buttonGenerateAndExport;
    private TextBox listNamesScale;
    private DataGridView dataGridViewScale;
}
