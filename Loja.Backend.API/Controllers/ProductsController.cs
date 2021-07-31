using Loja.Backend.DBObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public List<Product> Get()
        {
            using (LojaContext context = new LojaContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
