using Nasa.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class MoveControl
    {
        private readonly Dictionary<Direction, Func<Coordinates, Coordinates>> MoveFunctions;

        public MoveControl()
        {
            MoveFunctions = new Dictionary<Direction, Func<Coordinates, Coordinates>>() {
                { Direction.North, MoveNorth },
                { Direction.East, MoveEast },
                { Direction.South, MoveSouth },
                { Direction.West, MoveWest }
            };
        }

        public Coordinates Move(Direction aDirection, Coordinates aCoordinates)
        {
            return MoveFunctions[aDirection](aCoordinates);
        }

        private Coordinates MoveWest(Coordinates aCoordinates)
        {
            return new Coordinates(aCoordinates.X - 1, aCoordinates.Y);
        }

        private Coordinates MoveSouth(Coordinates aCoordinates)
        {
            return new Coordinates(aCoordinates.X, aCoordinates.Y - 1);
        }

        private Coordinates MoveEast(Coordinates aCoordinates)
        {
            return new Coordinates(aCoordinates.X + 1, aCoordinates.Y);
        }

        private Coordinates MoveNorth(Coordinates aCoordinates)
        {
            return new Coordinates(aCoordinates.X, aCoordinates.Y + 1);
        }
    }
}
