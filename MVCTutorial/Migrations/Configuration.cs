namespace MVCTutorial.Migrations
{
    using MVCTutorial.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCTutorial.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCTutorial.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(p => p.ProductID,
                new Product
                {
                    ProductID = 1,
                    Description = "TV",
                    Brand = "Samsung",
                    Quantity = 1,
                    Price = 500,
                },

                new Product
                {
                    ProductID = 2,
                    Description = "Móvil",
                    Brand = "Apple",
                    Quantity = 1,
                    Price = 600,
                }

             );
        }
    }
}
