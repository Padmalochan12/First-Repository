using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasa.MarsRover
{
    public class Rover
    {
        public RoverDeployParameter RoverDeploy { get; }

        public Rover(RoverDeployParameter aRoverDeploy)
        {
            RoverDeploy = aRoverDeploy;
        }

        public string Navigate() {

            var navigate = new MarsRoverNavigation(RoverDeploy);
            return navigate.Navigate();
        }
    }
}
