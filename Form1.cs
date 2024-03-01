namespace MediaPlayer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnOpenFiles_Click(object sender, EventArgs e)
    {
        OpenFileDialog open = new OpenFileDialog();
        open.ShowDialog();

        MediaPlayer1.URL = open.FileName;
    }
}
