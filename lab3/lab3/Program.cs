using lab3;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var setConfig = new SettingsConfiguration();
setConfig.Configure(app);
