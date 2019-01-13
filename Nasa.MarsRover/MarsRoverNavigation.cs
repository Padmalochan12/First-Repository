using System;
using Nasa.MarsRover.Models;

namespace Nasa.MarsRover
{
    public class MarsRoverNavigation
    {
        private NavigateCommand _navigateCommand;
        private RoverDeployParameter _roverDeployParameter;
        private MoveControl _moveControl;

        public MarsRoverNavigation(RoverDeployParameter roverDeployParameter)
        {
            _roverDeployParameter = roverDeployParameter;
            _navigateCommand = new NavigateCommand();
            _moveControl = new MoveControl();
        }

        public string Navigate()
        {

            foreach (var path in _roverDeployParameter.Commands)
            {
                UpdateDirection(path, _roverDeployParameter.RoverDirection);
                if (path == Command.MoveForward)
                {
                    UpdateCoordinates(path);
                }
            }

            return _roverDeployParameter.DeployCoordinates.X + " " + _roverDeployParameter.DeployCoordinates.Y + " " + OutputDirectionFormat(_roverDeployParameter.RoverDirection);
        }

        private char OutputDirectionFormat(Direction aDirection)
        {
            return CommandParser.OutputDirectionDictionary[aDirection];
        }

        private void UpdateCoordinates(Command path)
        {
            var newCoordinates = _moveControl.Move(_roverDeployParameter.RoverDirection, _roverDeployParameter.DeployCoordinates);
            if (ValidCoordinates(newCoordinates))
            {
                _roverDeployParameter.UpdateCoordinates(newCoordinates);
            }
            else
            {
                throw new RoverException("Invalid Coordinates to move for Rover");
            }
        }

        private bool ValidCoordinates(Coordinates newCoordinates)
        {
            return newCoordinates.X >= 0 && newCoordinates.Y >= 0 &&
                   newCoordinates.X <= _roverDeployParameter.PlateuCoordinates.X && newCoordinates.Y <= _roverDeployParameter.PlateuCoordinates.Y;
        }

        private void UpdateDirection(Command path, Direction direction)
        {
            var newDir = _navigateCommand.GetNextDirection(path, direction);
            _roverDeployParameter.UpdateDirection(newDir);
        }
    }
}