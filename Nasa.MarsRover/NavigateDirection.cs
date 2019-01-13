using Nasa.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class NavigateDirection
    {
        private readonly LinkedList<Direction> _direction;

        public NavigateDirection()
        {
            _direction = new LinkedList<Direction>();
            _direction.AddLast(Direction.North);
            _direction.AddLast(Direction.East);
            _direction.AddLast(Direction.South);
            _direction.AddLast(Direction.West);
        }

        public Direction TurnRight(Direction aDirection) {
            var node = _direction.Find(aDirection);
            return node.Next == null ? _direction.First.Value : node.Next.Value;
        }

        public Direction TurnLeft(Direction aDirection)
        {
            var node = _direction.Find(aDirection);
            return node.Previous == null ? _direction.Last.Value : node.Previous.Value;
        }
    }
}
