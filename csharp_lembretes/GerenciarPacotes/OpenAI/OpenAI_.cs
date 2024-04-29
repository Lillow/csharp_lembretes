namespace csharp_lembretes.GerenciarPacotes.OpenAI;

using OpenAI_API;
internal class OpenAI_
{
    public async void OpenAI()
    {

        var cliente = new OpenAIAPI("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");

        var chat = cliente.Chat.CreateConversation();

        chat.AppendSystemMessage("Resuma a banda Linkin Park em um parágrafo.");

        string resposta1 = await chat.GetResponseFromChatbotAsync();

        string resposta2 = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();

        Console.WriteLine(resposta1);
        Console.WriteLine(resposta2);
    }
}
