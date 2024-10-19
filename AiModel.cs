using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
namespace TalkToMe;
#pragma warning disable SKEXP0001, SKEXP0003, SKEXP0010, SKEXP0011, SKEXP0050, SKEXP0052
public class AIModel
{
    public ChatHistory ChatHistory { get; set; } = new("You are an AI Chat Bot");
    public string ModelID { get; set; } = "llama3.2";
    static Uri EndPoint => new("http://localhost:11434/v1");
    static IKernelBuilder Builder => Kernel.CreateBuilder();
    public Kernel? ChatKernalModel { get; set; }
    public void ResetChatHistory() => ChatHistory = new("You are an AI Chat Bot");
    public IAsyncEnumerable<StreamingChatMessageContent> AiUserAgent(string message)
    {
        Kernel ChatKernal() => Builder.AddOpenAIChatCompletion(ModelID, EndPoint, "").Build();
        ChatHistory.AddUserMessage(message);
        return ChatKernal().GetRequiredService<IChatCompletionService>()
            .GetStreamingChatMessageContentsAsync(ChatHistory, null, ChatKernalModel = ChatKernal());
    }
   
}
