
using Site.Core.Entities;

namespace Site.Entity.Entities;

public class Article:EntityBase
    {    
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public int ReadTime { get; set; }
        public int ClickCount { get; set; }
        public ICollection<ArticleTranslation> Translations { get; set; } // Makalenin çevirileri
        
        //[ForeignKey("AuthorId")]
        public int AuthorId { get; set; } // Makaleyi yazan kullanıcının Id'si
        public User Author { get; set; } // Makaleyi yazan kullanıcı
        public ICollection<Category> Categories { get; set; } // Makalenin kategorileri
        
        
    }
