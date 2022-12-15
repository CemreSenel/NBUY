using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db"));   
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit= true;//Þifre içinde mutlaka rakam bulunsun.
    options.Password.RequireLowercase= true; //Þifre içinde mutlaka kucuk harf bulunsun.
    options.Password.RequireUppercase= true;   //Þifre içinde mutlaka buyuk harf bulunsun. 
    options.Password.RequiredLength= 6;    //Þifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric= true;  //Þifre içinde en az bir alfanumerýk karakterler (.,/)bulunmasý
                                                    //zorunlu olsun
    #endregion

    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 3;//Basarýsýz gýrýs deneme sayýsý en fazla 5 olsun.
    //eger 5 kez hatalý gýrýs denemesý yaparsa hesap kýlýtlensýn.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10); //Kilitlenmýs hesabýn tekrar
    // gýrýs yapabýlmesý ýcýn 5 dk beklemesý gerekýr.
    #endregion

    #region UserSettings
    options.User.RequireUniqueEmail= true;//Benzersiz e-mail adresi ile kayýt olunabýlýr.Yaný 
                                          //daha onceden kayýt olunmus býr mail adresi ile kayýt olunamaz.
    #endregion

    #region SignSettings
    options.SignIn.RequireConfirmedEmail = false;//true ise email onayý aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber = false; //true ise telefon numarasý onayý aktiftir.
    #endregion


});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//Eðer acýlabýlmesý ýcýn logýn olmanýn zorunlu oldugu
    //býr istekte bulunulursa kullanýcýnýn yonlendýrýlecegý sayfa burasý olacak.
    //account controllerdaký logýn actýon metodu
    options.LogoutPath= "/account/logout"; //Kullanýcý cýkýs yaptýgýnda yonlendýrýlecek sayfa
    options.AccessDeniedPath = "/account/accessdenied"; //Yetkýsýz gýrýs sýrasýnda yonlendýrýlecek sayfa
    options.SlidingExpiration = true; //Varsayýlan cookie yasam suresýnýn (20 dk) ya da ayarlanan
    //yasam suresýnýn her yený istek sýrasýnda sýfýrlanarak yenýden baslamasýný saglar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//Yasam suresýný ayarlar.
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name=".ShoppingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(

    "smtp.office365.com",587,true,"wissen_core@hotmail.com","Wissen123."
    ));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
