using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
  public  class Library
    {
       public  List<Planet> Planets { get; private set; }

        public Library()
        {
            Planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet)
        {
            Planets.Add(planet);
        }
        public void RemovePlanet(Planet planet)
        {
            Planets.Remove(planet);
        }
    }
}
