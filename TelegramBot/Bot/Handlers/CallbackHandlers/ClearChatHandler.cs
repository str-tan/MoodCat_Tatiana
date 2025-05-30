using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Bot.Handlers.ICallbackHandlers;
using TelegramBot.Bot.Lib.Keyboards;

namespace TelegramBot.Bot.Handlers.CallbackHandlers;

 public class ClearChatHandler : ICallbackHandler
{
    public bool CanHandle(string data) => data == "G"; // обробляє G

    public async Task HandleAsync(
        ITelegramBotClient bot,
        CallbackQuery callbackQuery,
        Dictionary<long, string> userMoods,
        Dictionary<long, int> userLastMessageIds,
        CancellationToken cancellationToken)
    {
        var chatId = callbackQuery.Message.Chat.Id;

        if (userLastMessageIds.TryGetValue(chatId, out int msgId))
        {
            try
            {
                await bot.DeleteMessageAsync(chatId, msgId, cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[!] Не вдалося видалити повідомлення: " + ex.Message);
            }
            userLastMessageIds.Remove(chatId);
        }

        userMoods.Remove(chatId);

        await bot.SendTextMessageAsync(
            chatId,
            "Чат очищено! Почнемо з чистого аркуша 🌸",
            replyMarkup: Keyboard.MainMenu,
            cancellationToken: cancellationToken);
    }
}
