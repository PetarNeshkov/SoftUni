﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
   public class Tire
    {
        public Tire(double tirePressure, int tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        public double TirePressure { get; set; }
        public int TireAge { get; set; }
    }
}
