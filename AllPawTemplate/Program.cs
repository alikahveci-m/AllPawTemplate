using AllPawTemplate.Models.DapperContext;
using AllPawTemplate.Repositories.AdvertRepository;
using AllPawTemplate.Repositories.CategoryRepository;
using AllPawTemplate.Repositories.CityRepository;
using AllPawTemplate.Repositories.ImageRepository;
using AllPawTemplate.Repositories.UserRepository;
using AllPawTemplate.Services.AdvertDetailService;
using AllPawTemplate.Services.HomeService;
using AllPawTemplate.Services.LoginService;
using AllPawTemplate.Services.SignupService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<IImageRepository, ImageRepository>();
builder.Services.AddTransient<IAdvertRepository, AdvertRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

builder.Services.AddTransient<IHomeService, HomeService>();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<ISignupService, SignupService>();
builder.Services.AddTransient<IAdvertDetailService, AdvertDetailService>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
