using Microsoft.EntityFrameworkCore;
using groupActivity.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapGet("/", context => {
    context.Response.Redirect("/Products");
    return Task.CompletedTask;
});

app.MapRazorPages();

app.Run();
