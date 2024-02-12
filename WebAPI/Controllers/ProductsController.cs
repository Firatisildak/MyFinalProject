using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled: gevşek bağımlılık
        //naming convention
        //IoC Container -- Inversion of Control
        IProductServise _productsService;

        public ProductsController(IProductServise productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var result=_productsService.GetAll();
            return result.Data;

        }

    }
}
