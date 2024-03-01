namespace MediaPlayer;

partial class Form1
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
        btnOpenFiles = new Button();
        ((System.ComponentModel.ISupportInitialize)MediaPlayer1).BeginInit();
        SuspendLayout();
        // 
        // MediaPlayer1
        // 
        MediaPlayer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        MediaPlayer1.Enabled = true;
        MediaPlayer1.Location = new Point(1, 1);
        MediaPlayer1.Name = "MediaPlayer1";
        MediaPlayer1.OcxState = (AxHost.State)resources.GetObject("MediaPlayer1.OcxState");
        MediaPlayer1.Size = new Size(959, 573);
        MediaPlayer1.TabIndex = 0;
        // 
        // btnOpenFiles
        // 
        btnOpenFiles.Anchor = AnchorStyles.Bottom;
        btnOpenFiles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnOpenFiles.Location = new Point(423, 580);
        btnOpenFiles.Name = "btnOpenFiles";
        btnOpenFiles.Size = new Size(115, 41);
        btnOpenFiles.TabIndex = 1;
        btnOpenFiles.Text = "Open files";
        btnOpenFiles.UseVisualStyleBackColor = true;
        btnOpenFiles.Click += btnOpenFiles_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 628);
        Controls.Add(btnOpenFiles);
        Controls.Add(MediaPlayer1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Media Player";
        ((System.ComponentModel.ISupportInitialize)MediaPlayer1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
    private Button btnOpenFiles;
}
