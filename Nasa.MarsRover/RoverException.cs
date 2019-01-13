using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class RoverException : Exception
    {
        public RoverException(string message) : base(message)
        {
        }
    }
}
