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
        TxtChat = new RichTextBox();
        BtnSpeak = new Button();
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
        splitContainer1.Panel1.Controls.Add(TxtChat);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(BtnSpeak);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 387;
        splitContainer1.TabIndex = 1;
        // 
        // TxtChat
        // 
        TxtChat.Dock = DockStyle.Fill;
        TxtChat.Font = new Font("Segoe UI", 19F);
        TxtChat.Location = new Point(0, 0);
        TxtChat.Name = "TxtChat";
        TxtChat.Size = new Size(800, 387);
        TxtChat.TabIndex = 1;
        TxtChat.Text = "";
        // 
        // BtnSpeak
        // 
        BtnSpeak.Dock = DockStyle.Fill;
        BtnSpeak.Font = new Font("Segoe UI", 19F);
        BtnSpeak.Location = new Point(0, 0);
        BtnSpeak.Name = "BtnSpeak";
        BtnSpeak.Size = new Size(800, 59);
        BtnSpeak.TabIndex = 0;
        BtnSpeak.Text = "Talk!";
        BtnSpeak.UseVisualStyleBackColor = true;
        BtnSpeak.Click += BtnSpeak_Click;
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
    private RichTextBox TxtChat;
    private Button BtnSpeak;
}
