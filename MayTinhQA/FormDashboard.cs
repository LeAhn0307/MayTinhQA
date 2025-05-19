using MayTinhQA.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            UC_Home uC = new UC_Home();
            addUserControl(uC);
        }
        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

=======
            UC_Home uC = new UC_Home();
            addUserControl(uC);
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UC_Customer uC = new UC_Customer();
            addUserControl(uC);
>>>>>>> 4d0282639e0ad6dd74b5b395fca0d319dbe040bb
        }
    }
}
