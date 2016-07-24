using Code.First.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.First.Data
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext()
        {
        }

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
            : base(options)
        { }

        public DbSet<Gender> Genders { get; set; }

    }
}
