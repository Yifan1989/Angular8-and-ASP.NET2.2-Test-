using Microsoft.EntityFrameworkCore;
using Test_Full.Models;

namespace Test_Full.Data
{
    public class ApplicationDbContext: DbContext  //Inheritance
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) //passing the option to the parent class which is DbContext
        {

        }
    }
}
