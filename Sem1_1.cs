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
    public partial class Sem1_1 : Form
    {
        public Sem1_1()
        {
            InitializeComponent();
        }

        // 1. Se dă o mulțime de puncte în plan.
        // Să se determine dreptunghiul de arie minimă care să conțină toate punctele date în interior.
        private void Sem1_1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen black = new Pen(Color.Black, 2);
            Random rnd = new Random();

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            int n = rnd.Next(100);
            int minX = width, minY = height, maxX = 0, maxY = 0;

            // Determina extremitatile dreptunghiului
            for (int i = 0; i < n; i++)
            {
                int xN = rnd.Next(10, width - 10);
                int yN = rnd.Next(10, height - 10);
                g.DrawEllipse(black, xN, yN, 2, 2);

                if (xN < minX) minX = xN;
                else if (xN > maxX) maxX = xN;

                if (yN < minY) minY = yN;
                else if (yN > maxY) maxY = yN;
            }

            // Deseneaza treiunghiul (+1 pt. ca punctele sa fie in interior)
            g.DrawRectangle(black, minX + 1, minY + 1, maxX - minX + 1, maxY - minY + 1);
        }
    }
}
