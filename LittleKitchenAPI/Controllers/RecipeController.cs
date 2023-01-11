using LittleKitchenAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LittleKitchenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeDbContext _context;

        public RecipeController(RecipeDbContext context)
        {
            _context = context;
        }
    }
}
