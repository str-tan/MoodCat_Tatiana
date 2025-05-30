

using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Bot.Lib.Methods;
using TelegramBot.Bot.Handlers.ICallbackHandlers;
namespace TelegramBot.Bot.Handlers.CallbackHandlers;

/*public class ContentHandler : ICallbackHandler
{
    public bool CanHandle(string data) => new[] { "MC", "AC", "PC" }.Contains(data);

    public async Task HandleAsync(
        ITelegramBotClient bot,
        CallbackQuery callbackQuery,
        Dictionary<long, string> userMoods,
        Dictionary<long, int> userLastMessageIds, // ← додано, щоб відповідало інтерфейсу
        CancellationToken cancellationToken)
    {
        string contentType = callbackQuery.Data switch
        {
            "MC" => "movies",
            "AC" => "anime",
            "PC" => "photos",
            _ => ""
        };

        if (!string.IsNullOrEmpty(contentType))
        {
            var chatId = callbackQuery.Message.Chat.Id;
            await BotMethod.GenerateContent(bot, chatId, contentType, userMoods, cancellationToken);
            await BotMethod.AskNextAsync(bot, chatId, cancellationToken);
        }
    }
}*/

