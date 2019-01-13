﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover.Models
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int xCoordinate, int yCoordinate)
        {
            X = xCoordinate;
            Y = yCoordinate;
        }
    }
}
