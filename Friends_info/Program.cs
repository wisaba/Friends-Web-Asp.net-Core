using Friends_info.Services;
using AutoMapper;
using Friends_info.Data;
using Friends_info.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Hangfire;
using Hangfire.MemoryStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();
builder.Services.AddHangfire(configuration => configuration
       .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
       .UseSimpleAssemblyNameTypeSerializer()
       .UseRecommendedSerializerSettings()
       .UseStorage(new MemoryStorage()));builder.Services.AddMvc();
builder.Services.AddScoped(typeof(FriendsRepository), typeof(FriendsService));
builder.Services.AddSingleton<Database>();
builder.Services.AddScoped(typeof(FriendsRepository),typeof(FriendsService));
var connectionString = builder.Configuration.GetConnectionString("FriendsInfoDb");
builder.Services.AddDbContext<Friends_info.Data.Context.Friends_infoDbContext>(config =>
{
    config.UseSqlServer("Data Source=DESKTOP-7HK4L9E;Initial Catalog=friendsDb;Integrated Security=True;Trust Server Certificate=True");
});



builder.Services.AddHangfireServer();


var automapperConfig = new MapperConfiguration(a =>
{
    a.AddProfile<Friends_info.Infrastructure.AutoMapperProfile>();
});


IMapper mapper = automapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Friends_info api");
});

app.UseRouting();

app.UseAuthorization();
app.UseHangfireDashboard();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();