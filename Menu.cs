using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrie_Computationala_Seminar
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonSem1_1_Click(object sender, EventArgs e)
        {
            Sem1_1 form = new Sem1_1();
            form.ShowDialog();
        }

        private void buttonSem1_2_Click(object sender, EventArgs e)
        {
            Sem1_2 form = new Sem1_2();
            form.ShowDialog();
        }

        private void buttonSem1_3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSem2_1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSem2_2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSem2_3_Click(object sender, EventArgs e)
        {

        }
    }
}
