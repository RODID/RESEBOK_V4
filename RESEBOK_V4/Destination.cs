﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESEBOK_V4
{
    public class Destination
    {
        public string? CityName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"{CityName} - {Year} - {Month} - {Day}";
        }
    }
}
