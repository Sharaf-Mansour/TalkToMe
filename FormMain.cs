namespace TalkToMe;
public partial class FormMain : Form
{
    private PiperRunner _playbackProgram;

    public FormMain() {
        _playbackProgram = new PiperRunner();
        this.FormClosing += (s, e) => _playbackProgram.Stop();
        InitializeComponent();
    }
   
    private async void BtnSpeak_Click(object sender, EventArgs e)
    {
        await _playbackProgram.Run(TxtChat.Text);
    }
}