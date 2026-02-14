using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    // this is how we can achieve dependency injection before the application is running
    // it extends the host which is the route of the application
    public static class HostExtensions
    {
        public static void AddSeedTestData(this IHost host)
        {
            using(IServiceScope scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;
                PizzaDbContext dbContext = services.GetRequiredService<PizzaDbContext>();
                DatabaseSeeder.AddTestData(dbContext);
            }
        }
    }


    // if we want seed data that is outside our migration 
    // AKA seed data that is not needed in every scenario in every environment/for test purposes
    // this is the best place to put it
    // if ever not sure do it this way
    public static class DatabaseSeeder
    {
        public static void AddTestData(PizzaDbContext dbContext)
        {
            if (dbContext.Pizzas.Any())
            {
                return;
                // stop if the database has already been seeded
            }

            // we can use find here because we have had to specify the ID in dbcontext on model creating
            // the alternative would to use .first or .where and match the name
            PizzaBase tomatoBase = dbContext.PizzaBases.Find(1);
            Topping pepperoniTopping = dbContext.Toppings.Find(2);

            Pizza pepperoniParadise = new Pizza
            {
                Name = "Pepperoni Paradise",
                IsGlutenFree = false,
                Base = tomatoBase,
                Toppings = new List<Topping>
                    {
                        pepperoniTopping
                    }
            };

            PizzaBase bbqBase = dbContext.PizzaBases.Find(2);
            Topping chickenTopping = dbContext.Toppings.Find(3);
            Topping sweetcornTopping = dbContext.Toppings.Find(7);
            Topping pepperTopping = dbContext.Toppings.Find(5);
            Topping olivesTopping = dbContext.Toppings.Find(9);

            Pizza bbqChickenFeast = new Pizza
            {
                Name = "BBQ Chicken Feast",
                IsGlutenFree = true,
                Base = bbqBase,
                Toppings = new List<Topping>
                    {
                        chickenTopping,
                        sweetcornTopping,
                        pepperTopping,
                        olivesTopping
                    }
            };

            dbContext.Pizzas.Add(pepperoniParadise);
            dbContext.Pizzas.Add(bbqChickenFeast);
            dbContext.SaveChanges();
        }
    }
}
