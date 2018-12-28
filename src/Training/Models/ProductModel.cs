using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.ComponentModel.DataAnnotations.Schema;

namespace Training.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductCd { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? Price { get; set; }
        public UnitClass Unit { get; set; }
        public TaxClass Tax { get; set; }
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

}

