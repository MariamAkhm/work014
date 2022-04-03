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
        int summ = 0;
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
                horror b = new horror();
                b.Show();
                
            }
        }

        private void picture14_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\1.jpg");
            picture14.Image = image;
            picture14.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
            //Image.FromFile($"{Environment.CurrentDirectory}\\1.jpg"); почему-то так не читается(((
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\2.jpg");
            picture2.Image = image;
            picture2.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture18_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\3.jpg");
            picture18.Image = image;
            picture18.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\4.jpg");
            picture5.Image = image;
            picture5.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture16_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\5.jpg");
            picture16.Image = image;
            picture16.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture23_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\6.jpg");
            picture23.Image = image;
            picture23.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture17_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\7.jpg");
            picture17.Image = image;
            picture17.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
            //Image.FromFile($"{Environment.CurrentDirectory}\\7.jpg"); почему-то так не читается(((
        }

        private void picture10_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\8.jpg");
            picture10.Image = image;
            picture10.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture25_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\9.jpg");
            picture25.Image = image;
            picture25.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

        private void picture21_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\10.jpg");
            picture21.Image = image;
            picture21.Invalidate();
            summ++;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\balls.txt", summ.ToString());
        }

       
    }
}
