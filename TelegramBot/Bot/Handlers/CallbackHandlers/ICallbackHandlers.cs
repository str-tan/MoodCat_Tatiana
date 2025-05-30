using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Bot.Handlers.ICallbackHandlers
{
    public interface ICallbackHandler
    {
        bool CanHandle(string data);

        Task HandleAsync(
        ITelegramBotClient bot,
        CallbackQuery callbackQuery,
        Dictionary<long, string> userMoods,
        Dictionary<long, int> userLastMessageIds,
        CancellationToken cancellationToken
    );
    }
}

