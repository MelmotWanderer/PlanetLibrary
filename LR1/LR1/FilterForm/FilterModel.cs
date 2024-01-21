using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class FilterModel : IFilterModel
    {
      private Library _library;
        public FilterModel(Library library)
        {
            _library = library;
        }

        public List<Planet> Filter(int index) 
        {
            List<Planet> filtredPlanets = new List<Planet>();
            foreach(Planet planet in _library.Planets)
            {
                if(planet.TypePlanet == index)
                {
                    filtredPlanets.Add(planet);
                }

            }
            return filtredPlanets;
        }

    }
}
