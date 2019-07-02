using System;
using Microsoft.AspNetCore.Identity;

namespace Test_Full.Models
{
    public class ApplicationUser : IdentityUser
    {


        // this is the column
        public string FullName { get; set; }
    }
}
