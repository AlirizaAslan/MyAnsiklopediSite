using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site.Entity.Entities;

namespace Namespace
{
    public class AppDbContext : DbContext
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
         .HasOne(a => a.Author)
         .WithMany(u => u.Articles)
        .HasForeignKey(a => a.AuthorId);
        
    }
        
    }
}