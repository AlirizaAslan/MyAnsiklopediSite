using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Namespace
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,int,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
       

    public DbSet<Article>Articles {get; set;}
 
     public DbSet<ArticleTranslation>ArticleTranslations{get; set;}

    public DbSet<Category>Categories {get; set;}

    public DbSet<User>Users {get; set;}

    public DbSet<Image>Images {get; set;}


     //mapping klasörünü override ediyoruz
    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        
        //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<Article>()
             .HasOne(a => a.Author)          // Article sınıfındaki navigasyon özelliği
             .WithMany(u => u.Articles)      // User sınıfındaki Article listesi (eğer bir User'ın birden çok Article'ı olabilirse)
             .HasForeignKey(a => a.AuthorId); // Article sınıfındaki dış anahtar sütunu
                                        
    //     builder.Entity<AppUser>()
    // .HasOne(u => u.Image)
    // .WithMany()
    // .HasForeignKey(u => u.ImageId)
    // .OnDelete(DeleteBehavior.Cascade); // Kaskad silme

    }
        
    }
}