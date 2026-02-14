using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    public class PizzaDbContext : DbContext
    {
        // for testing
        public PizzaDbContext()
        {

        }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<Topping> Toppings { get; set; }

        public DbSet<PizzaBase> PizzaBases { get; set; }


        // if we want seed data that is inside our migration 
        // AKA seed data on every environment/not for test purposes
        // this is the best place to put it
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddSeedData(modelBuilder);
        }

        private void AddSeedData(ModelBuilder modelBuilder)
        {
            // add bases
            PizzaBase tomatoBase = new PizzaBase
            {
                Id = 1,
                Name = "Tomato"
            };
            PizzaBase bbqBase = new PizzaBase
            {
                // at this point in on model creating the ID must be specified, we think this is dumb
                Id = 2,
                Name = "BBQ"
            };
            modelBuilder.Entity<PizzaBase>().HasData(
                tomatoBase,
                bbqBase
            );

            // add topping
            Topping hamTopping = new Topping
            {
                Id = 1,
                Name = "Ham"
            };
            Topping pepperoniTopping = new Topping
            {
                // at this point in on model creating the ID must be specified, we think this is dumb
                Id = 2,
                Name = "Pepperoni"
            };
            Topping chickenTopping = new Topping
            {
                Id = 3,
                Name = "Chicken"
            };
            Topping pineappleTopping = new Topping
            {
                Id = 4,
                Name = "Pineapple"
            };
            Topping pepperTopping = new Topping
            {
                Id = 5,
                Name = "Pepper"
            };
            Topping onionTopping = new Topping
            {
                Id = 6,
                Name = "Onion"
            };
            Topping sweetcornTopping = new Topping
            {
                Id = 7,
                Name = "Sweetcorn"
            };
            Topping sausageTopping = new Topping
            {
                Id = 8,
                Name = "Sausage"
            };
            Topping olivesTopping = new Topping
            {
                Id = 9,
                Name = "Olives"
            };
            Topping tunaTopping = new Topping
            {
                Id = 10,
                Name = "Tuna"
            };
            modelBuilder.Entity<Topping>().HasData(
                hamTopping,
                pepperoniTopping,
                chickenTopping,
                pineappleTopping,
                pepperTopping,
                onionTopping,
                sweetcornTopping,
                sausageTopping,
                olivesTopping,
                tunaTopping
            );

            
        }
    }
}
