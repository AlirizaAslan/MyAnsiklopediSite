using Microsoft.AspNetCore.Builder;
using Site.Data.DataLayerExtantions;
using Site.Service.Extantions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

         
builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtantions();

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

app.UseEndpoints(endpoints=>
{
    endpoints.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

        endpoints.MapDefaultControllerRoute();
        
    

});

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// app.MapDefaultControllerRoute();  //alttaki kodun fonksiyon hali
// //  name: "default",
// //     pattern: "{controller=Home}/{action=Index}/{id?}"); 
app.Run();
