using Filter.Jwt;
using HRM.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Middleware;
using System.Net;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = actionContext =>
    {
        var keys = actionContext.ModelState.Keys;
        List<object> errorsValue = new List<object>();
        var modelError = actionContext.ModelState.Values.SelectMany(model => model.Errors);
        var errors = modelError.ToList().Select(err => err.ErrorMessage);
        int index = 0;
        errors.ToList().ForEach(item =>
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values.Add(keys.ToList()[index], item);
            errorsValue.Add(values);
            index++;
        });
        return new BadRequestObjectResult(new
        {
            StatusCode = (int)HttpStatusCode.BadRequest,
            Message = errorsValue
        });
    };
});

builder.Services.AddControllers().AddJsonOptions(x =>
               x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<AdminTokenFilter>();
builder.Services.AddScoped<UserTokenFilter>();
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("connString");
builder.Services.AddDbContext<MySQLDBContext>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseCors("MyPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
