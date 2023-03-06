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
    public partial class Sem1_2 : Form
    {
        public Sem1_2()
        {
            InitializeComponent();
        }

        // 2. Se dau două mulțimi de puncte în plan.
        // Pentru fiecare punct din prima mulțime să se găsească cel mai apropiat punct din cea de a doua mulțime.
        private void Sem1_2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen black = new Pen(Color.Black, 2);
            Pen green = new Pen(Color.Green, 2);
            Pen red = new Pen(Color.Red, 2);
            Random rnd = new Random();

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            int n = rnd.Next(100), m = rnd.Next(100);

            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int xN = rnd.Next(width);
                int yN = rnd.Next(height);
                points[i] = new Point(xN, yN);

                g.DrawEllipse(red, xN, yN, 1, 1);
            }

            for (int i = 0; i < m; i++)
            {
                int xM = rnd.Next(width);
                int yM = rnd.Next(height);

                g.DrawEllipse(green, xM, yM, 1, 1);

                // Init. distanta minima si indicele punctului minim
                double distMin = Math.Sqrt((points[0].X - xM) * (points[0].X - xM) + (points[0].Y - yM) * (points[0].Y - yM));
                int indicePunctMin = 0;

                // Calculeaza distanta punctului actual din M la fiecare dintre punctele din N si salveaza cea mai mica distanta
                for (int j = 0; j < n; j++)
                {
                    double dist = Math.Sqrt((points[j].X - xM) * (points[j].X - xM) + (points[j].Y - yM) * (points[j].Y - yM));

                    if (dist < distMin)
                    {
                        distMin = dist;
                        indicePunctMin = j;
                    }
                }

                // Leaga perechea de puncte ceruta printr-un segment (+2 compenseaza pt. marimea punctului)
                g.DrawLine(black, xM + 2, yM + 2, points[indicePunctMin].X + 2, points[indicePunctMin].Y + 2);
            }
        }
    }
}
