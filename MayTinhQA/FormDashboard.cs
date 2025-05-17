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
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (btnWishlist.Visible == false && btnCommunicate.Visible == false)
            {
                btnWishlist.Visible = true;
                btnCommunicate.Visible = true;
            }
            else
            {
                btnWishlist.Visible = false;
                btnCommunicate.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
