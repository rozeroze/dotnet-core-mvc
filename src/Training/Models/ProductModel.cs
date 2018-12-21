using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Training.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductCd { get; set; }
        public string ProductName { get; set; }
        //public decimal Price { get; set; } // SQLServer ではdecimalに指定された型が存在しない
        public int Price { get; set; }
        public UnitClass Unit { get; set; }
        public TaxClass Tax { get; set; }
        public DeleteClass Delete { get; set; }
    }

    public enum UnitClass
    {
        Pieces = 0,
        Kilogram = 1
    }

    public enum TaxClass
    {
        TaxIn = 0,
        TaxOut = 1
    }

    public enum DeleteClass
    {
        Normal = 0,
        Delete = 1
    }

}

