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
    public partial class SearcherPlanet : Form, ISearchView
    {
        public event Action OpenedSearchPlanet;
        public event Action SearchedPlanet;
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
            SearchedPlanet?.Invoke();
        }
    }
}
