using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.UILayer.AdminUI
{
    public partial class HomeView : UserControl
    {
        AdminHomeForm owner;
        public HomeView(AdminHomeForm owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dfdfdfdf");
        }

        private void HomeView_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
