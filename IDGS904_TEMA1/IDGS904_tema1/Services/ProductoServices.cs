using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductoServices
    {
        public List <Producto> ObtenerProducto()
        {
            var producto1 = new Producto()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutos Rojos",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 5)

            };

            var producto2 = new Producto()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango piña",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 5)

            };

            return new List<Producto> { producto1, producto2};
        }
    }
}