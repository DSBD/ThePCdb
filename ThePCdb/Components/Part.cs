﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class Part
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Rating { get; set; }
        protected string Type { get; set; }
        protected string InternalPartID { get; set; }

        public Part(string name, double price, int rating, string type, string IPID)
        {
            Name = name;
            Price = price;
            Rating = rating;
            Type = type;
            InternalPartID = IPID;
        }
    }
}