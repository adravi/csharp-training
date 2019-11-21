using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : Controller
    {
        private Dictionary<int, string> Fruits = new Dictionary<int, string>();

        public FruitsController()
        {
            Fruits.Add(1, "apple");
            Fruits.Add(2, "banana");
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Fruits.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Fruits[id];
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Fruits.Remove(id);
        }
    }
}