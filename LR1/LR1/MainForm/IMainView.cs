using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    interface IMainView : IView
    {
        event Action OpenedCreatorPlanet;
        event Action<int> RemovedPlanet;
        event Action OpenedFilterPlanet;
        event Action OpenedSearchPlanet;
        event Action ClearingFilterPlanet;
        void UpdateListView(List<Planet> planet);
        void EnableButtonClearFilter(bool isEnabled);

    }
}
