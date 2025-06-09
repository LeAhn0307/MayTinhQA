using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhQA.UserControls
{
    public partial class UC_Email : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-5ET5TOG;Initial Catalog=crm;Integrated Security=True";
        private List<dynamic> selectedCustomers = new List<dynamic>();
        private List<string> selectedEmails = new List<string>();

        public UC_Email()
        {
            InitializeComponent();
            LoadKhachHang();
            LoadTemplates();
            
        }

        private void btnChooseCustomers_Click(object sender, EventArgs e)
        {
            var fcc = new FormChooseCus();
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                // Lấy danh sách email đã chọn
                var emails = fcc.SelectedEmails;
                // Hiển thị lên textbox hoặc dùng để gửi email
                txtEmail.Text = string.Join(";", emails);
                // Lưu lại để gửi email hàng loạt
                selectedEmails = emails;
            }
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT idkhachhang, tenkhachhang, email FROM khachhang", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbKhachHang.Items.Add(new
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2)
                    });
                }
            }

            cbKhachHang.DisplayMember = "Name";
            cbKhachHang.SelectedIndexChanged += CbKhachHang_SelectedIndexChanged;
        }

        private void CbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic selected = cbKhachHang.SelectedItem;
            txtEmail.Text = selected.Email;
            UpdateNoiDungTheoKhachHang();
        }

        private void LoadTemplates()
        {
            cbTemplate.Items.Add("Chúc mừng sinh nhật");
            cbTemplate.Items.Add("Cảm ơn sau mua hàng");
            cbTemplate.Items.Add("Ưu đãi tháng này");
            cbTemplate.Items.Add("Thông báo bảo hành");
            cbTemplate.SelectedIndexChanged += (s, e) => UpdateNoiDungTheoTemplate();
            cbAuto.Items.Add("Chúc mừng sinh nhật");
            cbAuto.Items.Add("Cảm ơn sau mua hàng");
            cbAuto.Items.Add("Ưu đãi tháng này");
            cbAuto.Items.Add("Thông báo bảo hành");
            cbAuto.SelectedIndex = 0;
            
        }

        private void UpdateNoiDungTheoKhachHang()
        {
            if (cbTemplate.SelectedItem != null)
                UpdateNoiDungTheoTemplate();
        }

        private void UpdateNoiDungTheoTemplate()
        {
            // Nếu có nhiều email được chọn từ FormChooseCus
            if (selectedEmails != null && selectedEmails.Count > 0)
            {
                // Lấy tên các khách hàng đã chọn (nếu cần, bạn có thể truyền thêm tên từ FormChooseCus)
                string tenKhachHang = "";
                if (selectedCustomers != null && selectedCustomers.Count == selectedEmails.Count)
                {
                    tenKhachHang = string.Join(", ", selectedCustomers.Select(c => c.Name));
                }
                else
                {
                    tenKhachHang = "quý khách";
                }

                switch (cbTemplate.SelectedItem?.ToString())
                {
                    case "Chúc mừng sinh nhật":
                        txtNoiDung.Text = $"Chúc mừng sinh nhật {tenKhachHang}! Cảm ơn bạn đã tin tưởng cửa hàng chúng tôi. Nhận ngay mã giảm giá 10% khi mua phụ kiện hôm nay!";
                        break;
                    case "Cảm ơn sau mua hàng":
                        txtNoiDung.Text = $"Xin cảm ơn {tenKhachHang} đã mua hàng tại cửa hàng của chúng tôi. Nếu có bất kỳ thắc mắc nào về sản phẩm, đừng ngần ngại liên hệ!";
                        break;
                    case "Ưu đãi tháng này":
                        txtNoiDung.Text = $"Chào {tenKhachHang}, tháng này cửa hàng đang có nhiều ưu đãi hấp dẫn dành riêng cho bạn! Truy cập website để xem ngay!";
                        break;
                    case "Thông báo bảo hành":
                        txtNoiDung.Text = $"Chào {tenKhachHang}, sản phẩm bạn mua sắp hết hạn bảo hành. Vui lòng mang đến cửa hàng để được hỗ trợ nhanh chóng.";
                        break;
                    default:
                        txtNoiDung.Text = "";
                        break;
                }
                return;
            }

            // Trường hợp chỉ chọn 1 khách hàng như cũ
            if (cbKhachHang.SelectedItem == null) return;

            dynamic kh = cbKhachHang.SelectedItem;
            string ten = kh.Name;

            switch (cbTemplate.SelectedItem.ToString())
            {
                case "Chúc mừng sinh nhật":
                    txtNoiDung.Text = $"Chúc mừng sinh nhật {ten}! Cảm ơn bạn đã tin tưởng cửa hàng chúng tôi. Nhận ngay mã giảm giá 10% khi mua phụ kiện hôm nay!";
                    break;
                case "Cảm ơn sau mua hàng":
                    txtNoiDung.Text = $"Xin cảm ơn {ten} đã mua hàng tại cửa hàng của chúng tôi. Nếu có bất kỳ thắc mắc nào về sản phẩm, đừng ngần ngại liên hệ!";
                    break;
                case "Ưu đãi tháng này":
                    txtNoiDung.Text = $"Chào {ten}, tháng này cửa hàng đang có nhiều ưu đãi hấp dẫn dành riêng cho bạn! Truy cập website để xem ngay!";
                    break;
                case "Thông báo bảo hành":
                    txtNoiDung.Text = $"Chào {ten}, sản phẩm bạn mua sắp hết hạn bảo hành. Vui lòng mang đến cửa hàng để được hỗ trợ nhanh chóng.";
                    break;
                default:
                    txtNoiDung.Text = "";
                    break;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string body = txtNoiDung.Text;
            int success = 0, fail = 0;

            // Nếu có danh sách khách hàng đã chọn thì gửi cho từng người
            if (selectedEmails != null && selectedEmails.Count > 0)
            {
                foreach (var email  in selectedEmails)
                {
                    try
                    {
                        MailMessage mail = new MailMessage("katoriii372003@gmail.com", email)
                        {
                            Subject = "Thông báo từ cửa hàng máy tính Quang Anh.",
                            Body = body,
                            IsBodyHtml = false
                        };

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("katoriii372003@gmail.com", "pddj kpii mcpj omcj"),
                            EnableSsl = true
                        };

                        smtp.Send(mail);
                        success++;
                    }
                    catch
                    {
                        fail++;
                    }
                }
                lblTrangThai.Text = $"✅ Gửi thành công: {success}, ❌ Thất bại: {fail}";
            }
            else // Nếu không thì gửi cho 1 khách hàng như cũ
            {
                string to = txtEmail.Text;
                try
                {
                    MailMessage mail = new MailMessage("katoriii372003@gmail.com", to)
                    {
                        Subject = "Thông báo từ cửa hàng máy tính Quang Anh.",
                        Body = body,
                        IsBodyHtml = false
                    };

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("katoriii372003@gmail.com", "pddj kpii mcpj omcj"),
                        EnableSsl = true
                    };

                    smtp.Send(mail);
                    lblTrangThai.Text = "✅ Gửi email thành công!";
                }
                catch (Exception ex)
                {
                    lblTrangThai.Text = "❌ Lỗi: " + ex.Message;
                }
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (selectedEmails == null || selectedEmails.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi gửi email tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbAuto.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại email sinh nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string template = cbAuto.SelectedItem.ToString();
            int success = 0, fail = 0;

            for (int i = 0; i < selectedEmails.Count; i++)
            {
                string email = selectedEmails[i];
                string name = (selectedCustomers != null && selectedCustomers.Count > i) ? selectedCustomers[i].Name : "quý khách";
                string body = "";

                // Tùy chỉnh nội dung theo template
                switch (template)
                {
                    case "Chúc mừng sinh nhật":
                        body = $"Chúc mừng sinh nhật {name}! Cảm ơn bạn đã đồng hành cùng cửa hàng.";
                        break;
                    // Có thể thêm các template khác nếu cần
                    default:
                        body = $"Chúc mừng sinh nhật {name}!";
                        break;
                }

                try
                {
                    MailMessage mail = new MailMessage("katoriii372003@gmail.com", email)
                    {
                        Subject = "Chúc mừng sinh nhật!",
                        Body = body,
                        IsBodyHtml = false
                    };

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("katoriii372003@gmail.com", "pddj kpii mcpj omcj"),
                        EnableSsl = true
                    };

                    smtp.Send(mail);
                    success++;
                }
                catch
                {
                    fail++;
                }
            }

            lblTrangThaiAuto.Text = $"✅ Gửi thành công: {success}, ❌ Thất bại: {fail}";
        }
    }
}
