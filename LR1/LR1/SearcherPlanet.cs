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
    public partial class SearcherPlanet : FormWithListView, ISearchView
    {
        public event Action OpenedSearchPlanet;
        public event Action<string> SearchedPlanet;
        public SearcherPlanet()
        {
            InitializeComponent();
        }

        private void SearchPlanet_Load(object sender, EventArgs e)
        {

        }
        private void OpenSearchPlanet(object sender, EventArgs e)
        {
            OpenedSearchPlanet?.Invoke();
        }
        private void SearchPlanet(object sender, EventArgs e)
        {
            SearchedPlanet?.Invoke(textBox1.Text);
        }
        public void UpdateListView(Planet planet)
        {
            listView1.Items.Clear();
            if(planet != null)
            {
                ListViewItem planetUI = CreateListViewItem(planet.Name, planet.EquatorialDiameter.ToString(), planet.Mass.ToString(), planet.OrbitalRadius.ToString(), planet.RotationPeriod.ToString(), planet.CountSatellites.ToString(), PlanetData.GetTypePlanet(planet.TypePlanet));

                listView1.Items.Add(planetUI); 
            }
         
        }
    }
}
