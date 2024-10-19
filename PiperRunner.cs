using NAudio.Wave;
using PiperSharp;
using PiperSharp.Models;
namespace TalkToMe;
public class SimplePlaybackProgram
{
    CancellationTokenSource _cts => new();
    public async Task Run(string msg)
    {
        const string ModelKey = "en_US-ryan-high";
        if (!File.Exists(PiperDownloader.DefaultPiperExecutableLocation))
            await PiperDownloader.DownloadPiper().ExtractPiper(PiperDownloader.DefaultLocation);

        var modelPath = Path.Join(PiperDownloader.DefaultModelLocation, ModelKey);

        var model = Directory.Exists(modelPath) ?
            await VoiceModel.LoadModelByKey(ModelKey) :
            await PiperDownloader.DownloadModelByKey(ModelKey);

        var provider = new PiperWaveProvider(new()
        {
            Model = model,
            UseCuda = false
        });
        provider.Start();

        _ = Task.Run(() => ConsoleThread(provider, msg, _cts.Token));
        _ = Task.Run(() => PlaybackThread(provider, _cts.Token));
    }
    void PlaybackThread(PiperWaveProvider provider, CancellationToken token)
    {
        using var outputDevice = new WaveOutEvent();
        outputDevice.Init(provider);
        outputDevice.Play();
        while (outputDevice.PlaybackState is PlaybackState.Playing && !token.IsCancellationRequested) Thread.Sleep(1000);
    }

    void ConsoleThread(PiperWaveProvider provider, string msg, CancellationToken token)
    {
        if (!token.IsCancellationRequested)
            provider.InferPlayback(msg).GetAwaiter().GetResult();
    }
    public void Stop() => _cts.Cancel();

}