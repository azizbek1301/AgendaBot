
using Telegram.Bot;
using ToDoBotAPI.Services;

namespace ToDoBotAPI.BackGroundServices
{
    public class BotBackGroundServices : BackgroundService
    {
        private TelegramBotClient _client;
        public BotBackGroundServices(TelegramBotClient botClient)
           => _client = botClient;
  
       
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Botimiz Eshitishni boshladi");
            _client.StartReceiving<UpdateHandlerServices>(null, stoppingToken);
            return Task.CompletedTask;
        }
    }
}
