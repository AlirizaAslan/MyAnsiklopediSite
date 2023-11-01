using Site.Core.Entities;

namespace Site.Entity.Entities;

 public class Category:EntityBase
    {       
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; } // Kategoriye ait makaleler

    }