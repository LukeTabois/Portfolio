using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Services
{
    public interface IPizzaService
    {
        List<Pizza> GetAll();

        Pizza? Get(int id);

        Pizza Add(Pizza pizza);

        void AddTopping(int pizzaId, int toppingId);

        void UpdateBase(int pizzaId, int baseId);

        void Delete(int id);
              

    }
}
