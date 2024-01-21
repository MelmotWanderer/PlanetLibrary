using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LR1
{
    public class FormWithListView : Form
    {
        private protected ListViewItem CreateListViewItem(string name, string equatorialDiameter, string mass, string orbitalRadius, string rotationPeriod, string countSatellites, string typePlanet)
        {

            ListViewItem newPlanet = new ListViewItem(name);
            newPlanet.SubItems.Add(equatorialDiameter);
            newPlanet.SubItems.Add(mass);
            newPlanet.SubItems.Add(orbitalRadius);
            newPlanet.SubItems.Add(rotationPeriod);
            newPlanet.SubItems.Add(countSatellites);
            newPlanet.SubItems.Add(typePlanet);
            return newPlanet;
        }
    }
}
