using Broadcaster.Helpers;
using Broadcaster.Hubs;
using Broadcaster.Models.AutoMapperProfilers;
using Broadcaster.Repository;
using Broadcaster.Repository.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IChatterContext, ChatterContext>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAutoMapperHelper, AutoMapperHelper>();

//AutomapperProfilers
builder.Services.AddAutoMapper(
    typeof(MessageProfiler),
    typeof(UserProfiler));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("default", builder =>
    {
        builder
        .WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("default");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<DatabaseHub>("/hubs/realtime-database");

app.Run();
