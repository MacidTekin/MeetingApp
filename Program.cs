var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // mvc şablonunu projeye tanıttık.

var app = builder.Build();

app.UseStaticFiles(); //statik dosylarının aktif edilmesi için yaptık.

app.UseRouting();

//mvc
//rest api
//razor pages

//{controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);

app.Run();
