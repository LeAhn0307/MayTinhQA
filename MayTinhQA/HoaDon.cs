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
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace MayTinhQA
{
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
            napdgvHoaDon();
        }
        private void napdgvHoaDon()
        {
            dgvhoadon.DataSource = Database.Query(" Select * from hoadon");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {

        }
    }
}
