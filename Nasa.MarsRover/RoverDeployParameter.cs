using Nasa.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class RoverDeployParameter
    {
        public Coordinates DeployCoordinates { get; private set; }
        public Coordinates PlateuCoordinates { get; private set; }
        public Direction RoverDirection { get; private set; }
        public IList<Command> Commands { get; private set; }

        public RoverDeployParameter(Coordinates plateauCoordinates, Direction roverDirection, Coordinates roverCoordinates, IList<Command> aCommands)
        {
            PlateuCoordinates = plateauCoordinates;
            RoverDirection = roverDirection;
            DeployCoordinates = roverCoordinates;
            Commands = aCommands;
        }

        public void UpdateCoordinates(Coordinates aCoordinates)
        {
            DeployCoordinates = aCoordinates;
        }

        public void UpdateDirection(Direction aDirection)
        {
            RoverDirection = aDirection;
        }
    }
}
