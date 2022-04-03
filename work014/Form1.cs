using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace work014
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            
        }

        private void nameT_TextChanged(object sender, EventArgs e)
        {
            string lines = nameT.Text;
            System.IO.File.WriteAllText(@"C:\Users\Home\source\repos\work014\work014\bin\Debug\netcoreapp3.1\names.txt", lines);
        }

        
        private void startB_Click(object sender, EventArgs e)
        {
            if (nameT == null)
            {
                MessageBox.Show("Заполните Данные Имени!");
            }
            Game a = new Game();
            a.Show();
           
        }
    }
}
