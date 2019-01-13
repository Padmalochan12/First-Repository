using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var rovers = InputParser.GetRovers("5 5\n1 2 N\nLMLMLMLMM");
                foreach (var rover in rovers)
                {
                    Console.WriteLine(rover.Navigate());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
