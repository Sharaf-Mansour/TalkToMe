using System.Speech.Recognition;
namespace TalkToMe;
public partial class FormMain : Form
{
    PiperRunner PlaybackProgram => new();
    AIModel AIModel = new();
    public FormMain()
    {
        this.FormClosing += (s, e) => PlaybackProgram.Stop();
        InitializeComponent();
        InitializeSpeechRecognizer();
    }
    async void BtnSpeak_Click(object sender, EventArgs e) => btnStart_Click();
    string TempText;
    async Task UserAI(string Message)
    {
        var CodeAgent = AIModel.AiUserAgent(Message);
        var chatMessage = "";

        await foreach (var content in CodeAgent) chatMessage += content?.Content?.Replace('*', ' ');

        await PlaybackProgram.Run(chatMessage);

        AIModel.ChatHistory.AddAssistantMessage(chatMessage);
        TxtChat.Text = chatMessage;
    }
    private SpeechRecognitionEngine recognizer;
    private void InitializeSpeechRecognizer()
    {
        recognizer = new SpeechRecognitionEngine();
        recognizer.SetInputToDefaultAudioDevice(); // Use default microphone

        recognizer.LoadGrammar(new DictationGrammar());

        recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
    }
    private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        TxtChat.Text += e.Result.Text + Environment.NewLine;
        TempText = e.Result.Text;
    }
    private async void btnStart_Click()
    {
        try
        {
            recognizer.Recognize();
            await UserAI(TempText);
        }
        catch  
        {
         }
    }
}