using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.UILayer.Common_UI;

namespace LMS.UILayer.Member_UI
{
    public partial class MemberHomeForm : Form
    {
        public MemberHomeForm()
        {
            InitializeComponent();
        }

        private void dfffdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.MdiParent = this;
            lf.Show();
        }
    }
}
