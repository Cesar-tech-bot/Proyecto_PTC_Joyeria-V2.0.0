using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Model.DTO
{
    internal class ProductsViewDTO : dbContext
    {
        private int IDProducto;
        private string NombreProducto;
        private string MaterialProducto;
        private string NombreProveedor;
        private string DescripcionProducto;

        public int IDProducto1 { get => IDProducto; set => IDProducto = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public string MaterialProducto1 { get => MaterialProducto; set => MaterialProducto = value; }
        public string NombreProveedor1 { get => NombreProveedor; set => NombreProveedor = value; }
        public string DescripcionProducto1 { get => DescripcionProducto; set => DescripcionProducto = value; }
    }
}
