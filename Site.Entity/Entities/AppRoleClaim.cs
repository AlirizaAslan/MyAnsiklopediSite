using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Entity.Entities
{
    public class AppRoleClaim : IdentityRoleClaim<int>
    {
        public int? Id { get; set; }
    }
}
