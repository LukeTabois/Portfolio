using ContosoPizza.Controllers;
using ContosoPizza.Data;
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ContosoPizza.Test
{
    public class PizzaControllerTest
    {
        private readonly PizzaController _pizzaController;

        private readonly Mock<IPizzaService> _mockPizzaService;
               

        public PizzaControllerTest()
        {
            _mockPizzaService = new Mock<IPizzaService>();
            _pizzaController = new PizzaController(_mockPizzaService.Object);

        }

        [Fact]
        public void Pizza_Get_WhenIdIsNotValid_ReturnNotFound()
        {
            // Arrange
            int expectedStatusCode = 404;
            int id = 1;
            _mockPizzaService.Setup(ps => ps.Get(id));


            // Act
            ActionResult<Pizza> response = _pizzaController.Get(id);
            NotFoundResult? actual = response.Result as NotFoundResult;            

            // Assert
            Assert.NotNull(actual.StatusCode);
            Assert.Equal(expectedStatusCode, actual.StatusCode);            

            _mockPizzaService.Verify(ps => ps.Get(id), Times.Once);
        }

        [Fact]
        public void Pizza_Get_WhenIdIsValid_ReturnOk()
        {
            // Arrange
            int expectedStatusCode = 200;
            int id = 1;
            Pizza expectedPizza = new Pizza
            {
                Id = id,
                Name = "Luke's Pizza",
                Base = new PizzaBase
                {
                    Id = 1,
                    Name = "Tomato"
                }
                // Toppings = .....
            };
            _mockPizzaService.Setup(ps => ps.Get(id)).Returns(expectedPizza);


            // Act
            ActionResult<Pizza> response = _pizzaController.Get(id);
            OkObjectResult? actual = response.Result as OkObjectResult;
            Pizza? actualPizza = actual.Value as Pizza;

            // Assert
            Assert.NotNull(actual.StatusCode);
            Assert.Equal(expectedStatusCode, actual.StatusCode);
            Assert.Equal(expectedPizza.Name, actualPizza.Name);

            _mockPizzaService.Verify(ps => ps.Get(id), Times.Once);
        }
                
    }
}