using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Bot.Handlers.ICallbackHandlers;


namespace TelegramBot.Bot.Handlers.CallbackHandlers
{
   /* public class SettingsHandler : ICallbackHandler
    {
        public bool CanHandle(string data) => data == "B";

        public async Task HandleAsync(
     ITelegramBotClient bot,
     CallbackQuery callbackQuery,
     Dictionary<long, string> userMoods,
     Dictionary<long, int> userLastMessageIds,
     CancellationToken cancellationToken)
        {
            await bot.SendMessage(
                callbackQuery.Message.Chat.Id,
                "Налаштування ще в розробці :)",
                cancellationToken: cancellationToken);
        }
    }*/
}
