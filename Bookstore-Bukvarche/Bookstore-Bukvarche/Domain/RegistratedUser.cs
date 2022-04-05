using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Domain
{
    public class RegistratedUser: IdentityUser
    {
        public string FisrtName { get; set; }

        public string LastName { get; set; }
    }
}
