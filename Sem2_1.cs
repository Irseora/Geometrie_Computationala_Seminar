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
    public partial class Sem2_1 : Form
    {
        public Sem2_1()
        {
            InitializeComponent();
        }

        private void Sem2_1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen black = new Pen(Color.Black, 3);
            Pen red = new Pen(Color.Red, 3);
            Pen green = new Pen(Color.Green, 3);
            Random rnd = new Random();

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            int n = rnd.Next(1000), d = rnd.Next(1, 100);

            // Deseneaza Q
            int xQ = rnd.Next(width), yQ = rnd.Next(height);
            g.DrawEllipse(red, xQ, yQ, 2, 2);

            // Genereaza cele n puncte
            for (int i = 0; i < n; i++)
            {
                int xN = rnd.Next(width), yN = rnd.Next(height);

                // Daca distanta <= d, deseneaza N verde
                if (Math.Sqrt(((xN - xQ) * (xN - xQ)) + ((yN - yQ) * (yN - yQ))) <= d)
                    g.DrawEllipse(green, xN, yN, 3, 3);
                // Altfel, deseneaza N negru
                else
                    g.DrawEllipse(black, xN, yN, 3, 3);
            }

            // Deseneaza cercul de raza d in jurul lui Q - ???
            // g.DrawEllipse(black, xQ - (d / 2), yQ - (d / 2), d, d);
        }
    }
}
