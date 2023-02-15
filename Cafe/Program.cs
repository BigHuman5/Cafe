using Cafe.BLL.Interfaces;
using Cafe.BLL.Services;
using Cafe.DAL.EF;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'AudienceContextConnection' not found.");

builder.Services.AddDbContext<CafeDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services
    .AddTransient<IGroupProductsServices, GroupProductsServices>()
    .AddTransient<IProductsServices, ProductsServices>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles();

// Add MVC to the request pipeline.
//app.UseMvc();

// Чтобы с других серверов подключать штуки
app.UseCors(options => options
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod());

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSwaggerUI();

app.Run();
