using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover.Models
{
    public class CommandParser
    {
        public static Dictionary<char, Direction> NavigationDictionary = new Dictionary<char, Direction> {
            {'N', Direction.North },
            {'E', Direction.East},
            {'S', Direction.South},
            {'W', Direction.West}
        };

        public static Dictionary<char, Command> CommandDictionary = new Dictionary<char, Command> {
            { 'L', Command.Left},
            { 'R', Command.Right},
            { 'M', Command.MoveForward}
        };


        public static Dictionary<Direction, char> OutputDirectionDictionary = new Dictionary<Direction, char> {
            { Direction.North,'N' },
            { Direction.East,'E'},
            { Direction.South,'S'},
          { Direction.West,'W'}
                };
    }
}
