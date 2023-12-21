using Site.Entity.Entities;

namespace Site.Entity.ViewModel.Articles;

public class ArticleDTO
{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public int ReadTime { get; set; }
        public int ClickCount { get; set; }
        public ICollection<ArticleTranslation> Translations { get; set; } // Makalenin çevirileri
        public ICollection<Category> Categories { get; set; } // Makalenin kategorileri

        public virtual string CreatedBy { get; set; }

        public virtual string ModifiedBy { get; set; }
        public virtual string DeletedBy { get; set; }

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool isDeleted { get; set; }
}
