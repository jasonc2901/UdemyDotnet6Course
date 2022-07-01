using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyCourse_BookLibraryApp.Models;

namespace UdemyCourse_BookLibraryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UdemyCourse_BookLibraryApp.Models.Book>? Books { get; set; }
    }
}
