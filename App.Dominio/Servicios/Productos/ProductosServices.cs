using App.Transversal.DTO.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio.Servicios.Productos
{
    public class ProductosServices
    {



        public ProductosDTO MapearInformacion()
        {

            ProductosDTO productos = new ProductosDTO();


            productos.Id = 1;
            productos.Nombre = "LECHE EN POLVO";
            productos.Precio = 23.500;
            productos.SKU = "FFFRER";
            productos.Descripcion = "PRODUCTOS PARA EL BEBE";

            CategoriaDTO categoria = new CategoriaDTO();

            categoria.CategoriaId = 1;
            categoria.CategoriaName = "LECHE";
            categoria.Descripcion = "CATEGORIA LECHE EN POLVO";


            productos.Categoria = categoria;


            return productos;

        }

    }
}
