using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Test_Full.Models
{
    public class ApplicationUser : IdentityUser
    {


        // this is the column
        // nvarchar is a string
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
    }
}
