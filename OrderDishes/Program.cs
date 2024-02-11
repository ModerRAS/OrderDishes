using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Caching.Distributed;
using OrderDishes.Data;
using OrderDishes.Data.DTO;
using NReco.Logging.File;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMasaBlazor();
builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddScoped<UserSession>();
var csredis = new CSRedis.CSRedisClient("redis:6379");
RedisHelper.Initialization(csredis);
builder.Services.AddSingleton<IDistributedCache>(new Microsoft.Extensions.Caching.Redis.CSRedisCache(RedisHelper.Instance));
builder.Services.AddSingleton(csredis);


builder.Services.AddLogging(loggingBuilder => {
    if (!Directory.Exists("logs")) {
        Directory.CreateDirectory("logs");
    }
    loggingBuilder.AddFile("logs/OrderDishes_{0:yyyy}-{0:MM}-{0:dd}.log", fileLoggerOpts => {
        fileLoggerOpts.FormatLogFileName = fName => {
            return string.Format(fName, DateTime.UtcNow);
        };
        fileLoggerOpts.FormatLogEntry = (msg) => {
            var log = new LogJson() { 
                DateTime = DateTime.Now.ToString("o"),
                LogLevel = msg.LogLevel.ToString(),
                LogName = msg.LogName,
                EventId = msg.EventId.Id,
                Message = msg.Message,
                Exception = msg.Exception?.ToString(),
            };
            return JsonConvert.SerializeObject(log, Formatting.None);
        };
    });
});
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.UseAuthentication();
app.UseAuthorization();

app.Run();
