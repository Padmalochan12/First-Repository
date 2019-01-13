using Nasa.MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public static class InputParser
    {
        private static RoverDeployParameter RoverDeployParameter;

        private static Coordinates DeployCoordinates;
        private static Coordinates PlateuCoordinates;
        private static Direction RoverDirection;
        private static IList<Command> Commands;

        public static IList<Rover> GetRovers(string input)
        {
            List<Rover> lstRover = new List<Rover>();
            lstRover.Add(GetRover(input));
            return lstRover;
        }

        public static Rover GetRover(string input)
        {
            var lines = input.Split('\n');

            for (int i = 1; i < lines.Length - 1; i += 2)
            {
                PlateauCoordinates(lines[0]);
                RoverCoordinates(lines[i]);
                Command(lines[i + 1]);

                RoverDeployParameter = new RoverDeployParameter(PlateuCoordinates, RoverDirection, DeployCoordinates, Commands);
            }

            return new Rover(RoverDeployParameter);
        }


        private static void PlateauCoordinates(string lines)
        {
            PlateuCoordinates = new Coordinates(int.Parse(lines.Split(' ')[0]), int.Parse(lines.Split(' ')[1]));
        }

        private static void RoverCoordinates(string lines)
        {
            DeployCoordinates = new Coordinates(int.Parse(lines.Split(' ')[0]), int.Parse(lines.Split(' ')[1]));
            RoverDirection = CommandParser.NavigationDictionary[(lines.Split(' ')[2])[0]];
        }

        private static void Command(string lines)
        {
            Commands = lines.ToCharArray().Select(arg => CommandParser.CommandDictionary[arg]).ToList();
        }
    }
}
