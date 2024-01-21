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
    public partial class Filter : Form, IFilterView
    {
        public event Action<int> FilteredPlanets;
        public Filter()
        {
            InitializeComponent();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < PlanetData._typePlanet.Count; i++)
            {
                comboBox1.Items.Add(PlanetData.GetTypePlanet(i));
            }
        }

        private void StartFilter(object sender, EventArgs e)
        {
            FilteredPlanets?.Invoke(comboBox1.SelectedIndex);
            Close();
        }
        
    }
}
