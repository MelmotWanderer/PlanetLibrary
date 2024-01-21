using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    interface ICreatorModel 
    {


        Planet CreateNewPlanet(string name, float equatorialDiameter, float mass, float orbitalRadius, float rotationPeriod, int countSatellites, int typePlanet);
       
    }
}
