namespace ProgramistaNorthwind.EF
{
    using Microsoft.EntityFrameworkCore;
    using Model;  

    public class NorthwindContext: DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        { }


        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order_Detail> Order_Details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        public virtual DbSet<Orders_Qry> Orders_Qries { get; set; }
        public virtual DbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        public virtual DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Invoice>()
                .HasKey(i => new { i.CustomerName });

            modelBuilder.Entity<Order_Detail>()
                .HasKey(o => new { o.OrderID });

            modelBuilder.Entity<Orders_Qry>()
               .HasKey(o => new { o.CompanyName });

            modelBuilder.Entity<Order_Details_Extended>()
               .HasKey(o => new { o.OrderID });

            modelBuilder.Entity<Sales_Totals_by_Amount>()
              .HasKey(o => new { o.OrderID });

            modelBuilder.Entity<Sales_by_Category>()
             .HasKey(o => new { o.CategoryID });

            modelBuilder.Entity<Sales_Totals_by_Amount>()
             .HasKey(o => new { o.OrderID });
        }
    }
}