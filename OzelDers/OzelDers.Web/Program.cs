

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OzelDers.Business.Abstract;
using OzelDers.Business.Concrete;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete;
using OzelDers.Data.Concrete.EfCore.Context;
using OzelDers.Entity.Concrete.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<OzelDersContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<OzelDersContext>().AddDefaultTokenProviders();


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OzelDersContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITeacherService, TeacherManager>();
builder.Services.AddScoped<IStudentService, StudentManager>();
builder.Services.AddScoped<IBranchService, BranchManager>();


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

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
