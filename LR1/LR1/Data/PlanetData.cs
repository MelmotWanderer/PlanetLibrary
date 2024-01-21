using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    static class PlanetData
    {
       static public Dictionary<int, string> _typePlanet = new Dictionary<int, string>() { 
        [0] = "Земная группа",
        [1] = "Газовый гигант"
        };



      static  public string GetTypePlanet(int index)
        {
            return _typePlanet[index];
        }
    }
}
