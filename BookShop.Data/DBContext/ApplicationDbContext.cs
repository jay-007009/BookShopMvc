using BookShop.Data.DbModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data.DBContext
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookImage> BookImages { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }

        public virtual DbSet<Rent> Rents { get; set; }

        public virtual DbSet<Student> Students { get; set; }

    }
}
