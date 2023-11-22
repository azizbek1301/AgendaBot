using Telegram.Bot;
using ToDoBotAPI.BackGroundServices;

var builder = WebApplication.CreateBuilder(args);


var token = builder.Configuration["token"];
builder.Services.AddSingleton(new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackGroundServices>();

var app = builder.Build();

app.Run();