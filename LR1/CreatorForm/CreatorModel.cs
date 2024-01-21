using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class CreatorModel : ICreatorModel 
    {
        private Library _library;
        public CreatorModel(Library library)
        {
            _library = library;
        }
        public Planet CreateNewPlanet(string name, float equatorialDiameter, float mass, float orbitalRadius, float rotationPeriod, int countSatellites, int typePlanet)
        {
            var planet = new Planet(name, equatorialDiameter, mass, orbitalRadius, rotationPeriod, countSatellites, typePlanet);
            _library.AddPlanet(planet);
            return planet;
        }
    }
}
