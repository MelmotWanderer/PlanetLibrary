using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    public interface ICreatorView : IView
    {
        event Action<string, string, string, string, string, string, int> CreatedPlanet;
        void ShowModalError();
    }
}
