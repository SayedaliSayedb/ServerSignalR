using ServerSignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<DataHub>("/dataHub");
app.Run();
