using ControllersExample.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //Adding one or many controller classes



var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
