using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaDbContext _pizzaDbContext;
        
        public PizzaService(PizzaDbContext pizzaDbContext)
        {
            _pizzaDbContext = pizzaDbContext;
        }



        // the service takes care of the crud methods generally
        public List<Pizza> GetAll()
        {
            return _pizzaDbContext.Pizzas
                .Include(p => p.Toppings)
                .Include(p => p.Base)
                .AsNoTracking()
                .ToList();
        }

        public Pizza? Get(int id)
        {
            return _pizzaDbContext.Pizzas
                .Include(p => p.Toppings)
                .Include(p => p.Base)
                .AsNoTracking()
                .SingleOrDefault(p => p.Id == id);
        }

        public Pizza Add(Pizza pizza)
        {
            _pizzaDbContext.Pizzas.Add(pizza);
            _pizzaDbContext.SaveChanges();

            return pizza;
        }

        public void AddTopping(int pizzaId, int toppingId)
        {
            Pizza? pizza = Get(pizzaId);
            Topping? topping = _pizzaDbContext.Toppings.SingleOrDefault(t => t.Id == toppingId);
            
            if (topping == null || pizza == null)
            {
                throw new InvalidOperationException("Pizza or Topping does not exist");
            }

            if (pizza.Toppings == null)
            {
                pizza.Toppings = new List<Topping>();
            }

            pizza.Toppings.Add(topping);

            _pizzaDbContext.SaveChanges();
        }

        public void UpdateBase(int pizzaId, int baseId)
        {
            Pizza? pizza = Get(pizzaId);
            PizzaBase? pizzaBase = _pizzaDbContext.PizzaBases.SingleOrDefault(b => b.Id == baseId);

            if (pizzaBase == null || pizza == null)
            {
                throw new InvalidOperationException("Pizza or Base does not exist");
            }

            pizza.Base = pizzaBase;

            _pizzaDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Pizza? pizza = Get(id);
            if (pizza is null)
            {
                throw new InvalidOperationException("Pizza does not exist");
            }                

            _pizzaDbContext.Pizzas.Remove(pizza);
            _pizzaDbContext.SaveChanges();
        }      

    }
}
