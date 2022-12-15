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
    options.Password.RequireDigit= true;//�ifre i�inde mutlaka rakam bulunsun.
    options.Password.RequireLowercase= true; //�ifre i�inde mutlaka kucuk harf bulunsun.
    options.Password.RequireUppercase= true;   //�ifre i�inde mutlaka buyuk harf bulunsun. 
    options.Password.RequiredLength= 6;    //�ifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric= true;  //�ifre i�inde en az bir alfanumer�k karakterler (.,/)bulunmas�
                                                    //zorunlu olsun
    #endregion

    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts= 3;//Basar�s�z g�r�s deneme say�s� en fazla 5 olsun.
    //eger 5 kez hatal� g�r�s denemes� yaparsa hesap k�l�tlens�n.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10); //Kilitlenm�s hesab�n tekrar
    // g�r�s yapab�lmes� �c�n 5 dk beklemes� gerek�r.
    #endregion

    #region UserSettings
    options.User.RequireUniqueEmail= true;//Benzersiz e-mail adresi ile kay�t olunab�l�r.Yan� 
                                          //daha onceden kay�t olunmus b�r mail adresi ile kay�t olunamaz.
    #endregion

    #region SignSettings
    options.SignIn.RequireConfirmedEmail = false;//true ise email onay� aktiftir.
    options.SignIn.RequireConfirmedPhoneNumber = false; //true ise telefon numaras� onay� aktiftir.
    #endregion


});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//E�er ac�lab�lmes� �c�n log�n olman�n zorunlu oldugu
    //b�r istekte bulunulursa kullan�c�n�n yonlend�r�leceg� sayfa buras� olacak.
    //account controllerdak� log�n act�on metodu
    options.LogoutPath= "/account/logout"; //Kullan�c� c�k�s yapt�g�nda yonlend�r�lecek sayfa
    options.AccessDeniedPath = "/account/accessdenied"; //Yetk�s�z g�r�s s�ras�nda yonlend�r�lecek sayfa
    options.SlidingExpiration = true; //Varsay�lan cookie yasam sures�n�n (20 dk) ya da ayarlanan
    //yasam sures�n�n her yen� istek s�ras�nda s�f�rlanarak yen�den baslamas�n� saglar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//Yasam sures�n� ayarlar.
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
