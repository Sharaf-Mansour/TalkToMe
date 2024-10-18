namespace TalkToMe;

partial class FormMain
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
        if (disposing && (components != null))
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
        splitContainer1 = new SplitContainer();
        richTextBox1 = new RichTextBox();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(richTextBox1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(button1);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 388;
        splitContainer1.TabIndex = 1;
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Fill;
        richTextBox1.Location = new Point(0, 0);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(800, 388);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // button1
        // 
        button1.Dock = DockStyle.Fill;
        button1.Location = new Point(0, 0);
        button1.Name = "button1";
        button1.Size = new Size(800, 58);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "FormMain";
        Text = "Form1";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private RichTextBox richTextBox1;
    private Button button1;
}
