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
    public partial class Form2 : Form, ICreatorView
    {
        public event Action<string, string, string, string, string, string, int> CreatedPlanet;
        private ModalErrorCreator modalErrorCreator;
        public Form2()
        {
            InitializeComponent();
            modalErrorCreator = new ModalErrorCreator();
        }
        
        public void ShowModalError()
        {
            
            modalErrorCreator.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void CreatePlanet(object sender, EventArgs e)
        {
            CreatedPlanet.Invoke(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.SelectedIndex);
        }
        
    }
}
