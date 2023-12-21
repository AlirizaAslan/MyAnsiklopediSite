using Site.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Entity.Entities
{
    public class AppUser:IdentityUser<int>,IEntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ImageId { get; set; } 
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set;}
    }
}
