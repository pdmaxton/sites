var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // Enables index.html as the default
app.UseStaticFiles();    // Serves files from wwwroot

app.Run();
