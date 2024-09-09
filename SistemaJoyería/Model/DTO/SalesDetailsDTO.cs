using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Model.DTO
{
    internal class SalesDetailsDTO : dbContext
    {
       
            private int IDSaleDetail;

            private int IDSale;

            private int IDProduct;

            private int Quantity;

            private decimal Price;

            public int IDSaleDetail1 { get => IDSaleDetail; set => IDSaleDetail = value; }
            public int IDSale1 { get => IDSale; set => IDSale = value; }
            public int IDProduct1 { get => IDProduct; set => IDProduct = value; }
            public int Quantity1 { get => Quantity; set => Quantity = value; }
            public decimal Price1 { get => Price; set => Price = value; }
        
    }
} 
