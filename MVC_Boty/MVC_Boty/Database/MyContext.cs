using Microsoft.EntityFrameworkCore;
using MVC_Boty.Models;

namespace MVC_Boty.Database
{
    public class MyContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<ProductDetails> Storage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=3b1_vostreljan_db1;user=vostreljan;password=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Categories>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Categories>()
                .HasOne(c => c.Category)
                .WithMany(c => c.ParentCategories)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => new {od.OrderId, od.ProductId});

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);

            modelBuilder.Entity<Orders>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Account)
                .WithMany(a => a.Orders)
                .HasForeignKey(o => o.AccountId);

            modelBuilder.Entity<Products>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Products>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<ProductDetails>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<ProductDetails>()
                .HasOne(pd => pd.Product)
                .WithMany(p => p.Storages)
                .HasForeignKey(pd => pd.ProductId);
        }
    }
}
