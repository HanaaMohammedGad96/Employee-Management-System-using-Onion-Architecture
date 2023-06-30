using Serilog.Events;
using Serilog;
using Application;
using Infrastructure;
using Persistence;
using WebApi.Middleware;
using WebApi.Config;

Log.Logger = (Serilog.ILogger)new LoggerConfiguration()
    .Enrich.FromLogContext()
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Debug)
    //.MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

//logger
builder.Host.UseSerilog();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

// Add services to the container.
builder.Services.AddControllers();

//builder.Services.AddApiVersioning(setupAction =>
//{
//    setupAction.AssumeDefaultVersionWhenUnspecified = true;
//    setupAction.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
//    setupAction.ReportApiVersions = true;
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOrigins", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee Management API"));
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();


app.UseCustomExceptionHandler();

app.UseCors("MyAllowedOrigins");

app.UseAuthorization();


app.MapControllers();

app.Run();