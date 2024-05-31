using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelcomeASP.Data
{
    public class MyIdentityUser : IdentityUser
    {
        public string CustomTag { get; set; }
    }
}
