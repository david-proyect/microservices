using App.Dominio.Servicios.Pokemon;
using App.Dominio.Servicios.Productos;
using App.Transversal.DTO.Pokemon;
using App.Transversal.DTO.Productos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mcs_productus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        [HttpGet(Name = "GetProducts")]
        public ProductosDTO GetProducts()
        {

            ProductosServices productosServices = new ProductosServices();

            return productosServices.MapearInformacion();

        }
    }
}
