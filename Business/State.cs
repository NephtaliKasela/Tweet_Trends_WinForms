﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class State
    {
        public string Name { get; set; }
        public List<Geographic_Coordinates> Coordinates { get; set; }

        public State()
        {
            Coordinates = new List<Geographic_Coordinates>();
        }
    }
}
