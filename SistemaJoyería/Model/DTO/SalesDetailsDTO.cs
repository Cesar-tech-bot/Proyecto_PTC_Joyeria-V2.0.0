﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Model.DTO
{
    internal class SalesDetailsDTO : dbContext
    {
       
            private int IDSaleDetail;

            private int IDProduct;

            private DateTime DayToSale;

            private int Quantity;

            private decimal Price;

        public int IDSaleDetail1 { get => IDSaleDetail; set => IDSaleDetail = value; }
        public int IDProduct1 { get => IDProduct; set => IDProduct = value; }
        public DateTime DayToSale1 { get => DayToSale; set => DayToSale = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public decimal Price1 { get => Price; set => Price = value; }
    }
} 
