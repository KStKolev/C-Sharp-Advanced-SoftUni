﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
