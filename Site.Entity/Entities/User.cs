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
        public  ICollection<Article> Articles { get; set; } // Kullanıcının makaleleri
        public  ICollection<Article> EditedArticles { get; set; } // Düzenlenen makaleler
        public  ICollection<Article> DeletedArticles { get; set; } // Silinen makaleler
        public  ICollection<Article> WrittenArticles { get; set; } // Yazılan makaleler

    }