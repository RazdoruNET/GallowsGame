using GallowsGame.Models.Entity;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "GallowsGame", Version = "v1" });
});

var app = builder.Build();

app.UseExceptionHandler("/Home/Error");
app.UseSwagger();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseSwaggerUI(options => {
    options.SwaggerEndpoint("/swagger/v1/swagger.json",
        "GallowsGame API");
});

app.Run();