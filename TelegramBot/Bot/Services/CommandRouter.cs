using TelegramBot.Bot.Handlers.CallbackHandlers;
using TelegramBot.Bot.Handlers.ICallbackHandlers;
using static TelegramBot.Bot.Lib.Methods.BotMethod;

namespace TelegramBot.Bot.Services
{
    public class CommandRouter
    {
        private readonly List<ICallbackHandler> handlers;

        public CommandRouter()
        {
            handlers = new List<ICallbackHandler>
        {
            new MoodHandler(),
            new MainMenuHandler(),
            new ContentHandler(),
            new SettingsHandler(),
            new ClearChatHandler(),
        };
        }

        public ICallbackHandler? Route(string data)
        {
            return handlers.FirstOrDefault(h => h.CanHandle(data));
        }
    }
}
