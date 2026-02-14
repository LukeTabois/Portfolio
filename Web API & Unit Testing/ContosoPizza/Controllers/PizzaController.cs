using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
    {
    public readonly IPizzaService _pizzaService;

    public PizzaController(IPizzaService pizzaService)
    {
        _pizzaService = pizzaService;
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => _pizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        Pizza? pizza = _pizzaService.Get(id);

        if (pizza == null)
        {            
            return NotFound();
        }
         
        return Ok(pizza);
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        // This code will save the pizza and return a result
        _pizzaService.Add(pizza);

        return CreatedAtAction(nameof(Create), new {id = pizza.Id}, pizza);
    }

    [HttpPut]
    public IActionResult AddTopping(int id, int toppingId)
    {
        _pizzaService.AddTopping(id, toppingId);

        return NoContent();
    }

    [HttpPatch]
    public IActionResult UpdateBase(int id, int baseId)
    {
        _pizzaService.UpdateBase(id, baseId);

        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // This code will delete the pizza and return a result
        Pizza? existingPizza = _pizzaService.Get(id);
        if (existingPizza == null)
        {
            return NotFound();
        }

        _pizzaService.Delete(id);

        return NoContent();
    }
}
