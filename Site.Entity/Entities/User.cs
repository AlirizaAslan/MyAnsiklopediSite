using System.ComponentModel.DataAnnotations.Schema;
using Site.Core.Entities;

namespace Site.Entity.Entities;

public class User:EntityBase 
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public int Level { get; set; }
        public int FollowerCount { get; set; } // Takipçi sayısı
        public ICollection<User> Followers { get; set; } // Kullanıcıyı takip edenler
        public ICollection<User> Following { get; set; } // Kullanıcının takip ettiği kişiler
         public ICollection<Article> SavedArticles { get; set; } // Kullanıcının kaydettiği makaleler
        public  ICollection<Article> Articles { get; set; } // Kullanıcının makaleleri
        public  ICollection<Article> EditedArticles { get; set; } // Düzenlenen makaleler

        [NotMapped]
        public ICollection<Article> UsersWhoReported { get; set; }   // Kullanıcının raporladığı makaleler

    }