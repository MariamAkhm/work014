using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace work014
{
    public partial class Game : Form
    {
        int i = 60;
        public Game()
        {
            InitializeComponent();
            i = Convert.ToInt32(time.Text);
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            --i;
            if (i == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }
        }

        private void picture14_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\1.jpg");
            picture14.Image = image;
            picture14.Invalidate();
            //Image.FromFile($"{Environment.CurrentDirectory}\\1.jpg"); почему-то так не читается(((
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\2.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture18_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\3.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\4.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture16_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\5.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture23_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\6.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture17_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\7.jpg");
            picture14.Image = image;
            picture14.Invalidate();
            //Image.FromFile($"{Environment.CurrentDirectory}\\7.jpg"); почему-то так не читается(((
        }

        private void picture10_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\8.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture25_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\9.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

        private void picture21_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\10.jpg");
            picture14.Image = image;
            picture14.Invalidate();
        }

    }
}
