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
        SuspendLayout();
        // 
        // buttonGenerateAndExport
        // 
        buttonGenerateAndExport.Location = new Point(55 , 362);
        buttonGenerateAndExport.Margin = new Padding(4 , 5 , 4 , 5);
        buttonGenerateAndExport.Name = "buttonGenerateAndExport";
        buttonGenerateAndExport.Size = new Size(249 , 35);
        buttonGenerateAndExport.TabIndex = 0;
        buttonGenerateAndExport.Text = "Gerar e Exportar Escalas";
        buttonGenerateAndExport.UseVisualStyleBackColor = true;
        buttonGenerateAndExport.Click += buttonGenerateAndExport_Click;
        // 
        // textBox1
        // 
        listNamesScale.Location = new Point(87 , 12);
        listNamesScale.Multiline = true;
        listNamesScale.Name = "textBox1";
        listNamesScale.Size = new Size(217 , 177);
        listNamesScale.TabIndex = 1;
        // 
        // KidsMinistryScale
        // 
        AutoScaleDimensions = new SizeF(8F , 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380 , 411);
        Controls.Add(listNamesScale);
        Controls.Add(buttonGenerateAndExport);
        Margin = new Padding(4 , 5 , 4 , 5);
        Name = "KidsMinistryScale";
        Text = "Formulário Principal";
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion

    private Button buttonGenerateAndExport;
    private TextBox listNamesScale;
}
