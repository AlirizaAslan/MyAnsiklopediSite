using Site.Core.Entities;

namespace Site.Entity.Entities;

 public class ArticleTranslation:EntityBase
    {
        public int ArticleId { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Article Article { get; set; }
    }
