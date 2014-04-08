namespace EntityLINQ.Data.Migrations
{ 
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityLINQ.DataModels;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityLINQ.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityLINQ.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Customers.AddOrUpdate(
              c => c.Id,
              new Customer { Id = 1, Name = "Jason", Birthday = DateTime.Now },
              new Customer { Id = 2, Name = "Ray", Birthday = DateTime.Now },
              new Customer { Id = 3, Name = "Derric", Birthday = DateTime.Now },
              new Customer { Id = 4, Name = "Jarred", Birthday = DateTime.Now },
              new Customer { Id = 5, Name = "Luke", Birthday = DateTime.Now },
              new Customer { Id = 6, Name = "Joe", Birthday = DateTime.Now },
              new Customer { Id = 7, Name = "Goerge", Birthday = DateTime.Now },
              new Customer { Id = 8, Name = "Andrew", Birthday = DateTime.Now },
              new Customer { Id = 9, Name = "Alex", Birthday = DateTime.Now },
              new Customer { Id = 10, Name = "John", Birthday = DateTime.Now }

            );

            context.Orders.AddOrUpdate(
              o => o.Id,
              new Order { Id = 1, Description = "Order 1", OrderDate = DateTime.Now, OrderTotal = 1, CustomerId = 1},
              new Order { Id = 2, Description = "Order 2", OrderDate = DateTime.Now, OrderTotal = 2, CustomerId = 2},
              new Order { Id = 3, Description = "Order 3", OrderDate = DateTime.Now, OrderTotal = 3, CustomerId = 3},
              new Order { Id = 4, Description = "Order 4", OrderDate = DateTime.Now, OrderTotal = 4, CustomerId = 4},
              new Order { Id = 5, Description = "Order 5", OrderDate = DateTime.Now, OrderTotal = 5, CustomerId = 5},
              new Order { Id = 6, Description = "Order 6", OrderDate = DateTime.Now, OrderTotal = 6, CustomerId = 6},
              new Order { Id = 7, Description = "Order 7", OrderDate = DateTime.Now, OrderTotal = 7, CustomerId = 7},
              new Order { Id = 8, Description = "Order 8", OrderDate = DateTime.Now, OrderTotal = 8, CustomerId = 8 },
              new Order { Id = 9, Description = "Order 9", OrderDate = DateTime.Now, OrderTotal = 9, CustomerId = 9 },
              new Order { Id = 10, Description = "Order 10", OrderDate = DateTime.Now, OrderTotal = 10, CustomerId = 10 }

            );


        }
    }
}
