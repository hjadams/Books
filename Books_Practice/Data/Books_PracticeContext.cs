using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Books_Practice.Models;

namespace Books_Practice.Data
{
    public class Books_PracticeContext : DbContext
    {
        public Books_PracticeContext (DbContextOptions<Books_PracticeContext> options)
            : base(options)
        {
        }

        public DbSet<Books_Practice.Models.Books> Books { get; set; }
    }
}
