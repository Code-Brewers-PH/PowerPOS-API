using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

// Add CORS Policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(
            "http://localhost:3000"
            )
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials();
    });
});

// Connection string to database
builder.Services.AddDbContext<RepositoryContext>(x =>
    x.UseSqlite(builder.Configuration.GetConnectionString("DefaultSqliteConnection")));

// To enable includes from EFCore
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Inject logging services
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

IdentityModelEventSource.ShowPII = true;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseStaticFiles();

//app.UseAuthentication(); Uncomment this if JWT is implemented
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
