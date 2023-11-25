using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crips_form
{


    public partial class Form2 : Form
    {
        private Point offset;

        private int r = 255;
        private int g = 0;
        private int b = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                gunaLabel1.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel6.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel5.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel7.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel4.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel9.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel8.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel3.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel2.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel15.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel14.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel13.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel12.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel16.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel18.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel10.ForeColor = Color.FromArgb(r, g, b);
                gunaLabel11.ForeColor = Color.FromArgb(r, g, b);



                if (r > 0 && b == 0)
                {
                    r -= 1;
                    g += 1;
                }

                if (g > 0 && r == 0)
                {
                    g -= 1;
                    b += 1;
                }

                if (b > 0 && g == 0)
                {
                    b -= 1;
                    r += 1;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    // Calculate the new position of the window based on the mouse movement and the offset
                    Point newPosition = PointToScreen(e.Location);
                    newPosition.Offset(-offset.X, -offset.Y);
                    Location = newPosition;
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            {
                if (e.Button == MouseButtons.Left)
                {
                    // Capture the offset between the mouse pointer and the top-left corner of the window
                    offset = new Point(e.X, e.Y);
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
