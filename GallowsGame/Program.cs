using GallowsGame.Interfaces;
using GallowsGame.Models.Entity;
using GallowsGame.Services;
using Microsoft.OpenApi.Models;
using AutoMapper;
using GallowsGame.Models.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(DTOMapperProfile));
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IQuestionAnswerService, QuestionAnswerService>();

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