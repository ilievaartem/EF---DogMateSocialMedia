using DogMateSocialMedia.BusinessLogicLayer.Interfaces.Services;
using DogMateSocialMedia.BusinessLogicLayer.Services;
using DogMateSocialMedia.DataAccessLayer;
using DogMateSocialMedia.DataAccessLayer.Data;
using DogMateSocialMedia.DataAccessLayer.Data.Repositories;
using DogMateSocialMedia.DataAccessLayer.Interface;
using DogMateSocialMedia.DataAccessLayer.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Налаштування рядка підключення
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Реєстрація AppDbContext з MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        connectionString,
        new MySqlServerVersion(new Version(8, 0, 25)),
        b => b.MigrationsAssembly("DogMateSocialMedia.DataAccessLayer")
    ));

// Реєстрація залежностей для репозиторіїв та сервісів
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUserService, UserService>();

// Додати AutoMapper для проекту
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Реєстрація контролерів
builder.Services.AddControllers();

// Налаштування Swagger для API-документації
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "DogMateSocialMedia.WebAPI",
        Version = "v1"
    });
});

var app = builder.Build();

// Автоматичне застосування міграцій при запуску
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();
}

// Налаштування Swagger для тестування API
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DogMateSocialMedia.WebAPI v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
