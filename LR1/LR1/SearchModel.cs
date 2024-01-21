using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class SearchModel : ISearchModel
    {
        private Library _library;
        public SearchModel(Library library)
        {
            _library = library;
        }

        public Planet FindPlanetInLibrary(string name)
        {
            
            foreach (Planet planet in _library.Planets)
            {

                Console.WriteLine(name);
                Console.WriteLine(planet.Name);
                    if (String.Equals(planet?.Name, name))
                    {
                    
                        return planet;
                    }
                
               
                
            }
            return null;

        }
    }
}
