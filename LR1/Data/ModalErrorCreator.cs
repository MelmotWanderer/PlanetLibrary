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
    public partial class ModalErrorCreator : Form, IView
    {
        public ModalErrorCreator()
        {
            InitializeComponent();
        }

        private void ModalErrorCreator_Load(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            this.ShowDialog();
        }
    }
}
