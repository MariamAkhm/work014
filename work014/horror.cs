using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace work014
{
    public partial class horror : Form
    {
        public horror()
        {
            InitializeComponent();
        }

        private void horrorP_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\horror.jpg");
            horrorP.Image = image;
            horrorP.Invalidate();
        }
    }
}
