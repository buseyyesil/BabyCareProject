using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Services.AboutServices;
using BabyCareProject.Services.BannerServices;
using BabyCareProject.Services.EventServices;
using BabyCareProject.Services.FooterServices.FooterGalleryServices;
using BabyCareProject.Services.FooterServices.FooterInformationServices;
using BabyCareProject.Services.FooterServices.FooterSubscribeServices;
using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.ProductServices;
using BabyCareProject.Services.ServiceServices;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection(nameof(DatabaseSettings)));
builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

// Service kayýtlarý
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IFooterInformationService, FooterInformationService>();
builder.Services.AddScoped<IFooterGalleryService, FooterGalleryService>();
builder.Services.AddScoped<IFooterSubscribeService, FooterSubscribeService>();

builder.Services.AddControllersWithViews()
    .AddViewComponentsAsServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Area route (Admin Panel)
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=AdminHome}/{action=Index}/{id?}"
);

// Default route (Frontend)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();