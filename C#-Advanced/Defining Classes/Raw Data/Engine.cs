﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
  public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
