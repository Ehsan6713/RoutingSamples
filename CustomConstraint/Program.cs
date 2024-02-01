using CustomConstraint.Extentions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureServices().ConfigurePipline();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.Run();
