using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class StudentContext : DbContext
    {
        public StudentContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
