using Data.Interfaces;
using BLL.Interfaces;
using BLL.Services;
using Data;
using Data.Models.Entity;
using GallowsGame.Services;
using Microsoft.OpenApi.Models;
using GallowsGame.Models.Mapper;
using Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(ControllerMapperProfile));
builder.Services.AddAutoMapper(typeof(DTOMapperProfile));
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<ICRUDRepositorie<Game>, CRUDRepositorie<Game>>();
builder.Services.AddScoped<ICRUDRepositorie<Question>, CRUDRepositorie<Question>>();
builder.Services.AddScoped<ICRUDRepositorie<QuestionAnswer>, CRUDRepositorie<QuestionAnswer>>();
builder.Services.AddScoped<ICRUDRepositorie<User>, CRUDRepositorie<User>>();

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