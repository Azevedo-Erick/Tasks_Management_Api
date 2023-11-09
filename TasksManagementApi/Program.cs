using System.Reflection;
using Microsoft.OpenApi.Models;
using TasksManagementApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo{ Title = "TodoAPI", Version = "v1" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    opt.IncludeXmlComments(xmlPath);
});
builder.Services.AddDbContext<ApplicationContext>();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoAPI V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(policyBuilder =>
{
    policyBuilder.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin();
});
app.MapControllers();

app.Run();