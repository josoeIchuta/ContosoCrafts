using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductService ProductoServicio;

        //Aqui el <Product> viene del archivo Producto de 'Models'
        public IEnumerable<Product> Productos { get; private set; }

        //Y aqui en los parametros del constructor, hay que definir el servicio que
        //vamos a utilizar en esta pagina
        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productoServicio)
        {
            _logger = logger;
            ProductoServicio = productoServicio;
        }

        public void OnGet()
        {
            Productos = ProductoServicio.GetProducts();
        }
    }
}
