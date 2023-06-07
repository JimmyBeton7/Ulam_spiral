using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ulam_spiral
{
    public partial class Form1 : Form
    {
        private const int PADDING = 10;
        private int _n;
        private int d;

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            var g = e.Graphics;
            var x = pictureBox1.Width / 2;
            var y = pictureBox1.Height / 2;
            int num = 1;
            var direction = 4;
            var step = 1;
            var step_done = 0;
            var direction_count = 0;

            while (num <= _n)
            {
                if (prime_only_btn.Checked == true)
                {
                    if (IsPrime(num) == true)
                    {
                        g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    }
                }
                else if (all_btn.Checked == true)
                {
                    g.FillRectangle(Brushes.Black, x, y, 1, 1);
                }
                else if (all_prime_red_btn.Checked == true)
                {
                    if (IsPrime(num) == true)
                    {
                        g.FillRectangle(Brushes.Red, x, y, 1, 1);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    }
                }

                switch (direction)
                {
                    case 1: //GÓRA
                        y -= d;
                        step_done++;

                        if (step_done == step)
                        {
                            direction = 2;
                            direction_count++;
                            step_done = 0;
                        }

                        if (direction_count == 2)
                        {
                            direction_count = 0;
                            step++;
                            step_done = 0;
                        }
                        break;
                    case 2: //LEWO
                        x -= d;
                        step_done++;

                        if (step_done == step)
                        {
                            direction = 3;
                            direction_count++;
                            step_done = 0;
                        }

                        if (direction_count == 2)
                        {
                            direction_count = 0;
                            step++;
                            step_done = 0;
                        }
                        break;
                    case 3: //DÓŁ
                        y += d;
                        step_done++;

                        if (step_done == step)
                        {
                            direction = 4;
                            direction_count++;
                            step_done = 0;
                        }

                        if (direction_count == 2)
                        {
                            direction_count = 0;
                            step++;
                            step_done = 0;
                        }
                        break;
                    case 4: //PRAWO
                        x += d;
                        step_done++;
  
                        if(step_done == step)
                        {
                            direction = 1;
                            direction_count++;
                            step_done = 0;
                        }

                        if (direction_count == 2)
                        {
                            direction_count = 0;
                            step++;
                            step_done = 0;
                        }

                        break;
                }
                num++;
            }
        }

    

        private void generuj_btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && density_cb.Text != "")
            {
                _n = int.Parse(textBox1.Text);
                d = int.Parse(density_cb.Text);
                pictureBox1.Refresh();
            }           
        }

        private void zamknij_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void all_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && density_cb.Text != "")
            {
                _n = int.Parse(textBox1.Text);
                d = int.Parse(density_cb.Text);
                pictureBox1.Refresh();
            }
        }

        private void prime_only_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && density_cb.Text != "")
            {
                _n = int.Parse(textBox1.Text);
                d = int.Parse(density_cb.Text);
                pictureBox1.Refresh();
            }
        }

        private void all_prime_red_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && density_cb.Text != "")
            {
                _n = int.Parse(textBox1.Text);
                d = int.Parse(density_cb.Text);
                pictureBox1.Refresh();
            }
        }

        private void zapisz_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                    bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Ulam_spiral");
        }
    }
}
