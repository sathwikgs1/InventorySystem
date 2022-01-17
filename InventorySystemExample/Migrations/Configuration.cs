namespace InventorySystemExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Company.DataLayer.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "InventorySystemExample.Models.InvenDbContext";
        }

        protected override void Seed(Company.DataLayer.CompanyDbContext context)
        {
            context.Inventories.AddOrUpdate(new Company.DomainModels.Inventory() { ProductID = 1, ProductName = "Stapler", Price = 100, AvailabilityStatus = "InStock" });
            context.Inventories.AddOrUpdate(new Company.DomainModels.Inventory() { ProductID = 2, ProductName = "Pen", Price = 50, AvailabilityStatus = "InStock" });
            context.Inventories.AddOrUpdate(new Company.DomainModels.Inventory() { ProductID = 3, ProductName = "Paper", Price = 45, AvailabilityStatus = "OutOfStock" });
            context.Inventories.AddOrUpdate(new Company.DomainModels.Inventory() { ProductID = 4, ProductName = "Mouse", Price = 1000, AvailabilityStatus = "InStock" });
            context.Inventories.AddOrUpdate(new Company.DomainModels.Inventory() { ProductID = 5, ProductName = "Keyboard", Price = 2000, AvailabilityStatus = "OutOfStock" });

        }
    }
}
