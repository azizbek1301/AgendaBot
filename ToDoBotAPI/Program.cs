using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using ToDoBotAPI.BackGroundServices;
using ToDoBotAPI.DataAcsess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var token = builder.Configuration["token"];
builder.Services.AddSingleton(new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackGroundServices>();

var app = builder.Build();

app.Run();