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
        textBox1 = new TextBox();
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
        textBox1.Location = new Point(87 , 12);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(217 , 177);
        textBox1.TabIndex = 1;
        // 
        // KidsMinistryScale
        // 
        AutoScaleDimensions = new SizeF(8F , 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380 , 411);
        Controls.Add(textBox1);
        Controls.Add(buttonGenerateAndExport);
        Margin = new Padding(4 , 5 , 4 , 5);
        Name = "KidsMinistryScale";
        Text = "Formulário Principal";
        ResumeLayout(false);
        PerformLayout();
    }

    private Button buttonGenerateAndExport;

    #endregion

    private TextBox textBox1;
}
