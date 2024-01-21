using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace LR1
{
   


   public class Planet
    {
        public string Name { get; private set; }

        public float EquatorialDiameter { get; private set; }
        
        public float Mass { get; private set; }
        public float OrbitalRadius { get; private set; }
        public float RotationPeriod { get; private set; }
        public int CountSatellites { get; private set; }


        public int TypePlanet { get; private set; }

        public Planet(string name, float equatorialDiameter, float mass, float orbitalRadius, float rotationPeriod, int countSatellites, int typePlanet) {
            Name = name;
            EquatorialDiameter = equatorialDiameter;
            Mass = mass;
            OrbitalRadius = orbitalRadius;
            RotationPeriod = rotationPeriod;
            CountSatellites = countSatellites;
            TypePlanet = typePlanet;
        }

    }
}
