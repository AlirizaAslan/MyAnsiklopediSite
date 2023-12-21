using Site.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(25);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(25);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(50);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            //ctrl ve alt tuşları ile birden çok satır seçebilirsin

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            
            var superadmin=new AppUser
            {
                //Id = Guid.Parse("9EE7F3A2-9787-4F52-AF19-11DD788BA40F"),
                Id=-1,
                UserName = "alirizaaslan2000@gmail.com",
                NormalizedUserName = "ALIRIZAASLAN2000@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "ALIRIZAASLAN2000@GMAIL.COM",
                PhoneNumber = "+905226895243",
                FirstName = "Alirıza",
                LastName = "Aslan",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                //ImageId=-1,//Guid.Parse("D5A78A10-21A8-49A3-A3B6-E21ADD292023"),

           };

            superadmin.PasswordHash = CreatePasswordHash(superadmin, "123456");
                var admin = new AppUser
                {
                   // Id = Guid.Parse("52296E36-52D2-4A53-858C-C884BAA6E4CC"),
                    Id=-2,
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    PhoneNumber = "+905226895243",
                    FirstName = "Admin",
                    LastName = "user",
                    PhoneNumberConfirmed = true,
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    //ImageId = -2,//Guid.Parse("D5A78A10-21A8-49A3-A3B6-E21ADD292023"),
                };
            admin.PasswordHash = CreatePasswordHash(admin, "123456");
            builder.HasData(superadmin,admin);          
            
            
            
            }


        private string CreatePasswordHash(AppUser appUser,string password){
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(appUser,password);
        }
    }
}
