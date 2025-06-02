using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA.UserControls
{
    public partial class UC_Choose_Customer : UserControl
    {
        private UC_Choose_Customer ucChooseCustomer;
        private Rectangle headerCheckBoxArea;
        private bool isHeaderCheckBoxChecked = false;
        private bool isHeaderCheckBoxClicked = false;
        public delegate void CustomerSelectedHandler(int id, string name, DataRow fullRow);
        public event CustomerSelectedHandler OnCustomerSelected;
        public UC_Choose_Customer()
        {
            InitializeComponent();
            dgvKhachhang.Paint += dgvKhachhang_Paint_1;
            dgvKhachhang.MouseClick += DgvKhachhang_MouseClick;
            dgvKhachhang.DataBindingComplete += DgvKhachhang_DataBindingComplete;
            dgvKhachhang.CellValueChanged += DgvKhachhang_CellValueChanged;
            dgvKhachhang.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvKhachhang.IsCurrentCellDirty)
                    dgvKhachhang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.RowHeadersVisible = false;
            dgvKhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        
        private void LoadData()
        {
            DataTable dt = Database.Query("SELECT kh.idkhachhang, kh.tenkhachhang, kh.email, kh.dienthoai, kh.ngaysinh, CONCAT(kh.diachi, ', ', q.tenquanhuyen, ', ', tp.tenthanhpho) AS diachi, ghichu FROM khachhang kh JOIN thanhpho tp ON kh.idthanhpho = tp.idthanhpho JOIN quanhuyen q ON kh.idquanhuyen = q.idquanhuyen");
            dgvKhachhang.DataSource = null;
            dgvKhachhang.Columns.Clear();
            dgvKhachhang.DataSource = dt;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "check";
            chk.Width = 30;
            chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachhang.Columns.Insert(0, chk);

            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Name = "stt";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvKhachhang.Columns.Insert(1, sttColumn);

            dgvKhachhang.Columns["idkhachhang"].Visible = false;
            dgvKhachhang.Columns["tenkhachhang"].HeaderText = "Họ Tên";
            dgvKhachhang.Columns["email"].HeaderText = "Email";
            dgvKhachhang.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dgvKhachhang.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvKhachhang.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvKhachhang.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvKhachhang.ClearSelection();
        }
        private void LoadFilterOptions()
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.AddRange(new[] {
                "Tên khách hàng", "Ngày sinh", "Địa chỉ", "Số điện thoại", "Email", "Ghi chú"
            });
            cbbFilter.SelectedIndex = 0;
        }

        private void DgvKhachhang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvKhachhang.Rows.Count; i++)
            {
                dgvKhachhang.Rows[i].Cells["stt"].Value = (i + 1).ToString();
            }
        }
        private void DgvKhachhang_Paint(object sender, PaintEventArgs e)
        {
            if (dgvKhachhang.Columns.Count == 0) return;

            Rectangle rect = dgvKhachhang.GetCellDisplayRectangle(0, -1, true);

            int checkboxSize = 14; // Kích thước checkbox (tuỳ chỉnh nếu cần)

            // ✅ Trừ đi phần cuộn ngang để checkbox di chuyển cùng header
            int xCheckbox = rect.X + (rect.Width - checkboxSize) / 2 - dgvKhachhang.HorizontalScrollingOffset;
            int yCheckbox = rect.Y + (rect.Height - checkboxSize) / 2;

            headerCheckBoxArea = new Rectangle(xCheckbox, yCheckbox, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(
                e.Graphics,
                headerCheckBoxArea,
                isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal
            );

        }
        
        private void DgvKhachhang_MouseClick(object sender, MouseEventArgs e)
        {
            if (headerCheckBoxArea.Contains(e.Location))
            {
                isHeaderCheckBoxChecked = !isHeaderCheckBoxChecked;
                isHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow row in dgvKhachhang.Rows)
                {
                    row.Cells["check"].Value = isHeaderCheckBoxChecked;
                }

                isHeaderCheckBoxClicked = false;
                dgvKhachhang.Invalidate();
            }
        }
        private void DgvKhachhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhachhang.Columns["check"].Index && !isHeaderCheckBoxClicked)
            {
                bool allChecked = dgvKhachhang.Rows.Cast<DataGridViewRow>()
                    .All(r => Convert.ToBoolean(r.Cells["check"].Value));
                isHeaderCheckBoxChecked = allChecked;
                dgvKhachhang.Invalidate();
            }
        }
        

        
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string field = cbbFilter.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(keyword) || string.IsNullOrWhiteSpace(field)) return;

            DataTable dt = dgvKhachhang.DataSource as DataTable;
            if (dt == null) return;

            var query = dt.AsEnumerable();

            switch (field)
            {
                case "Tên khách hàng":
                    query = query.Where(r => r.Field<string>("tenkhachhang").ToLower().Contains(keyword));
                    break;
                case "Ngày sinh":
                    query = query.Where(r => r.Field<DateTime>("ngaysinh").ToString("dd/MM/yyyy").Contains(keyword));
                    break;
                case "Địa chỉ":
                    var parts = keyword.Split(' ');
                    query = query.Where(r => parts.All(p => r.Field<string>("diachi").ToLower().Contains(p)));
                    break;
                case "Số điện thoại":
                    query = query.Where(r => r.Field<string>("dienthoai").ToLower().Contains(keyword));
                    break;
                case "Email":
                    query = query.Where(r => r.Field<string>("email").ToLower().Contains(keyword));
                    break;
                case "Ghi chú":
                    query = query.Where(r => r.Field<string>("ghichu").ToLower().Contains(keyword));
                    break;
            }

            dgvKhachhang.DataSource = query.Any() ? query.CopyToDataTable() : dt.Clone();
            isHeaderCheckBoxChecked = false;
            dgvKhachhang.Invalidate();
        }
        private void UC_Choose_Customer_Load(object sender, EventArgs e)
        {
            cbbFilter.Items.Clear();
            cbbFilter.Items.Add("Tên khách hàng");
            cbbFilter.Items.Add("Ngày sinh");
            cbbFilter.Items.Add("Địa chỉ");
            cbbFilter.Items.Add("Số điện thoại");
            cbbFilter.Items.Add("Email");
            cbbFilter.Items.Add("Ghi chú");
            cbbFilter.SelectedIndex = 0;
            LoadData();
        }

        private void dgvKhachhang_Paint_1(object sender, PaintEventArgs e)
        {
            Rectangle rect = dgvKhachhang.GetCellDisplayRectangle(0, -1, true);
            int checkboxSize = 14;
            int x = rect.X + (rect.Width - checkboxSize) / 2 - dgvKhachhang.HorizontalScrollingOffset;
            int y = rect.Y + (rect.Height - checkboxSize) / 2;
            headerCheckBoxArea = new Rectangle(x, y, checkboxSize, checkboxSize);

            ControlPaint.DrawCheckBox(e.Graphics, headerCheckBoxArea, isHeaderCheckBoxChecked ? ButtonState.Checked : ButtonState.Normal);
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            if (dgvKhachhang.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvKhachhang.CurrentRow.Cells["idkhachhang"].Value);
                string name = dgvKhachhang.CurrentRow.Cells["tenkhachhang"].Value.ToString();

                // Lấy DataRow gốc từ DataTable
                DataTable dt = dgvKhachhang.DataSource as DataTable;
                if (dt != null)
                {
                    string filter = $"idkhachhang = {id}";
                    DataRow[] matched = dt.Select(filter);
                    if (matched.Length > 0)
                    {
                        OnCustomerSelected?.Invoke(id, name, matched[0]);
                        return;
                    }
                }

                // Fallback nếu không tìm thấy dòng
                OnCustomerSelected?.Invoke(id, name, null);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public event EventHandler OnCancel;
        private void btnhuy_Click(object sender, EventArgs e)
        {
            ucChooseCustomer.Visible = false;
        }
        
    }
}
