using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.UILayer.AdminUI
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void allMembersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MemberForm))
                {
                    form.Activate();
                    return;
                }
            }
            MemberForm lf = new MemberForm();
            lf.MdiParent = this;
            lf.Show();
        }
    }
}
