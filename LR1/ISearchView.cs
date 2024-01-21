using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    interface ISearchView : IView
    {
        event Action OpenedSearchPlanet;
         event Action SearchedPlanet;
    }
}
