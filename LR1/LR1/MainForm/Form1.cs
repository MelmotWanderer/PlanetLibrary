using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : FormWithListView, IMainView
    {
        public event Action<int> RemovedPlanet;
        public event Action OpenedCreatorPlanet;
        public event Action OpenedFilterPlanet;
        public event Action ClearingFilterPlanet;
        public event Action OpenedSearchPlanet;
        public Form1()
        {
            InitializeComponent();
            RemovedPlanet += RemoveListViewItem;
            

        }
        public new void Show()
        {
            Application.Run(this);
        }
        public void UpdateListView(List<Planet> planets)
        {
            listView1.Items.Clear();
            foreach(var planet in planets)
            {
                ListViewItem planetUI= CreateListViewItem(planet.Name, planet.EquatorialDiameter.ToString(), planet.Mass.ToString(), planet.OrbitalRadius.ToString(), planet.RotationPeriod.ToString(), planet.CountSatellites.ToString(),PlanetData.GetTypePlanet(planet.TypePlanet));
                listView1.Items.Add(planetUI);
            }
      
          
           
        }
        public void EnableButtonClearFilter(bool isEnabled)
        {
            
            button1.Enabled = isEnabled;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenSearchPlanet(object sender, EventArgs e)
        {
            OpenedSearchPlanet?.Invoke();
        }
        private void ClearFilter(object sender, EventArgs e)
        {
            ClearingFilterPlanet?.Invoke();
        }
     
        private void OpenCreatorPlanet(object sender, EventArgs e)
        {
            OpenedCreatorPlanet?.Invoke();
        }
        private void OpenFilterPlanet(object sender, EventArgs e)
        {
            OpenedFilterPlanet?.Invoke();
        }
        private void RemovePlanet(object sender, EventArgs e)
        {
            RemovedPlanet?.Invoke(listView1.SelectedItems[0].Index);
        }
      
        private void RemoveListViewItem(int index)
        {
            listView1.Items.Remove(listView1.Items[index]);
        }
        
    }
}
