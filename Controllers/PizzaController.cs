
using BlazorApp1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace BlazorApp1.Controllers
{
    [Route("PizzaSpecials")]
    [ApiController]
    public class PizzaController : Controller
    {
        private readonly PizzaStoreContext _storeContext;

        public PizzaController(PizzaStoreContext pizzaStoreContext)
        {
            _storeContext = pizzaStoreContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
        {
            return (await _storeContext.PizzaSpecials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}

