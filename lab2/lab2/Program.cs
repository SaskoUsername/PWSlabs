using lab2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var message = new EmailSender();

app.MapGet("/", () => message.SendMessage());

app.Run();
