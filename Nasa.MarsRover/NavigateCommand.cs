using Nasa.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class NavigateCommand
    {
        private readonly Dictionary<Command, Func<Direction, Direction>> NavigateCommandFunctions;
        private readonly NavigateDirection _navigateDirection;

        public NavigateCommand()
        {
            NavigateCommandFunctions = new Dictionary<Command, Func<Direction, Direction>>() {
                { Command.Left, Turnleft },
                { Command.Right, TurnRight },
                { Command.MoveForward, Move }
            };

            _navigateDirection = new NavigateDirection();
        }

        public Direction GetNextDirection(Command aCommand, Direction aDirection)
        {
            return NavigateCommandFunctions[aCommand](aDirection);
        }

        private Direction Move(Direction arg)
        {
            return arg;
        }

        private Direction TurnRight(Direction arg)
        {
            return _navigateDirection.TurnRight(arg);
        }

        private Direction Turnleft(Direction arg)
        {
            return _navigateDirection.TurnLeft(arg);
        }
    }
}
