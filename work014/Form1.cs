using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void ClickT(object sender, EventArgs e)
        {
            MessageBox.Show("Заолните данные!");
        }

        private void startB_Click(object sender, EventArgs e)
        {
            Game a = new Game();
            a.Show();

        }
    }
}
