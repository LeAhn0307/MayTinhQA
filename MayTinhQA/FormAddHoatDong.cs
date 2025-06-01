using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MayTinhQA.UserControls;

namespace MayTinhQA
{
    public partial class FormAddHoatDong : Form
    {
        private UC_Activities UC_Activities;
        private int _idDichvu;
        private bool isAdding = false;
        private bool isEditing = false;
        private int currentEditingRowIndex = -1;
        public FormAddHoatDong(UC_Activities parent)
        {
            InitializeComponent();
            this.UC_Activities = parent;
        }
        public FormAddHoatDong(UC_Activities parent, int idDichvu)
        {
            InitializeComponent();
            this.UC_Activities = parent;
            this._idDichvu = idDichvu;
            isEditing = true;
            //LoadThanhPho();
            //LoadThongTinKhachHang();
        }
    }
}
