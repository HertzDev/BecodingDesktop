﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Models.General
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public string Existence { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }

    }
}
