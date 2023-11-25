using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crips_form
{
    public partial class Form1 : Form
    {

        private Point offset;

        private int r = 255;
        private int g = 0;
        private int b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            base.Hide();
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

        private void Form1_Load(object sender, EventArgs e)
        {
         

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                gunaLabel1.ForeColor = Color.FromArgb(r, g, b);
                gunaCirclePictureBox1.ForeColor = Color.FromArgb(r, g, b);
                gunaButton1.ForeColor = Color.FromArgb(r, g, b);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI Crips\n.NET Crips ");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            base.Hide();
        }
    }
}
