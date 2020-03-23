namespace Laborator5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductContext : DbContext
    {
        // Your context has been configured to use a 'Model2' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Laborator5.Model2' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model2' 
        // connection string in the application configuration file.
        //public ProductContext()
        //    : base("name=Model2")
        //{
        //}
        public ProductContext() : base("name=ProductContext") { }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Product>().Map(m => { m.Properties(p => new { p.SKU, p.Description, p.Price }); 
                m.ToTable("Product", "BazaDeDate"); 
            }).Map(m => { m.Properties(p => new { p.SKU, p.ImageURL }); 
                m.ToTable("ProductWebInfo", "BazaDeDate"); 
            });

        }



    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}