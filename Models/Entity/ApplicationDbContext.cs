using System;
using System.Collections.Generic;
using Belliso.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Belliso.Models.Entity;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public  DbSet<Brand> Brands { get; set; }

    public  DbSet<Cart> Carts { get; set; }

    public  DbSet<Category> Categories { get; set; }

    public  DbSet<Customer> Customers { get; set; }

    public  DbSet<DeliveryAddress> DeliveryAddresses { get; set; }

    public DbSet<ImportProduct> ImportProducts { get; set; }

    public DbSet<Manager> Managers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductAttribute> ProductAttributes { get; set; }

    public DbSet<ProductImage> ProductImages { get; set; }

    public DbSet<ReceiptProduct> ReceiptProducts { get; set; }
    public DbSet<Conversation> Conversations {  get; set; }
    public DbSet<Message> Messages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
     => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=BellisoDB;Integrated Security=True;TrustServerCertificate=True");

}
