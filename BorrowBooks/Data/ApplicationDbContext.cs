using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BorrowBooks.Models;
using System;

namespace BorrowBooks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BorrowBooks.Models.User> User { get; set; }
        public DbSet<BorrowBooks.Models.Book> Book { get; set; }


    }
}