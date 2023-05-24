using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Transversal.DTO.Productos
{
    public class ProductosDTO
    {
        /// <summary>
        /// SOLO NUMERO
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// SOLO CADENAS
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// SOLO DECIMALES
        /// </summary>
        public double Precio { get; set; }

        /// <summary>
        /// SOLO CADENAS
        /// </summary>
        public string SKU { get; set; }


        /// <summary>
        /// SOLO CADENAS
        /// </summary>
        public string Descripcion { get; set; }


        /// <summary>
        /// OBJETO DE CATEGORIA
        /// </summary>
        public CategoriaDTO Categoria { get; set; }


    }
}
