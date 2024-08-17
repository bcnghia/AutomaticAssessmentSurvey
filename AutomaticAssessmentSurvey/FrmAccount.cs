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

namespace AutomaticAssessmentSurvey
{
    public partial class FrmAccount : Form
    {
        private string filePath;
        private Account account;
        
        public FrmAccount()
        {
            InitializeComponent();
            cboGioiTinh.DrawItem += new DrawItemEventHandler(cboGioiTinh_DrawItem);

            string relativePath = @"Data\account.txt";
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            var controller = new ControllerDataAccount(filePath);
            account = controller.GetDataAccount();

            if (account != null)
            {
                txtUser.Text = account.User;
                txtPassword.Text = account.Password;
                cboGioiTinh.Text = account.GioiTinh;
            }
            else
            {
                // Xử lý trường hợp account là null, ví dụ: thông báo lỗi hoặc thiết lập giá trị mặc định
                MessageBox.Show("Không thể tải thông tin tài khoản. Vui lòng kiểm tra file dữ liệu.");
            }

            txtHDSD.Text = "NOTE:" +
                           "\n\n- Nhập thông tin tài khoản vào và nhấn Save để sử dụng" +
                           "\n\n- Trường hợp cần sửa thông tin thì sửa trực tiếp và nhấn Save" +
                           "\n\n- Phần mềm lưu cùng lúc chỉ một tài khoản > Muốn nhiều hơn thì donate:))" +
                           "\n\n- (●'◡'●)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            account.User = txtUser.Text;
            account.Password = txtPassword.Text;
            account.GioiTinh = cboGioiTinh.Text;
            new ControllerDataAccount(filePath).EditData(account);

            //if (set.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    MessageBox.Show($"Successfully registered {txtUser.Text}!", "Information!");
            //} dùng để thông báo rằng tài khoản đã được lưu vào database
            MessageBox.Show("Lưu tài khoản thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new ControllerDataAccount(filePath).DeleteData();
            MessageBox.Show("Xóa tài khoản thành công!");
        }

        private void cboGioiTinh_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index>=0)
            {
                // Lấy combobox
                ComboBox cbo = (ComboBox)sender;

                // Lấy màu nền khi được chọn
                Color selectedColor = SystemColors.Highlight;

                // Lấy màu chữ khi được chọn
                Color selectedForeColor = SystemColors.HighlightText;

                // Tạo một Brush để vẽ văn bản
                Brush textBrush = new SolidBrush(cbo.ForeColor);

                // Kiểm tra xem item có được chọn không
                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

                // Vẽ nền của item khi được chọn
                e.Graphics.FillRectangle(new SolidBrush(isSelected ? selectedColor : cbo.BackColor), e.Bounds);

                // Vẽ văn bản
                string text = cbo.Items[e.Index].ToString();
                SizeF textSize = e.Graphics.MeasureString(text, cbo.Font);

                float x = (float)(e.Bounds.Width - textSize.Width) / 2;
                float y = (float)(e.Bounds.Height - textSize.Height) / 2;

                e.Graphics.DrawString(text, cbo.Font, textBrush, e.Bounds.Left + x, e.Bounds.Top + y);

                // Giải phóng bộ nhớ của Brush
                textBrush.Dispose();

                // Nếu item được chọn, đặt màu chữ
                if (isSelected)
                    e.Graphics.DrawString(text, cbo.Font, new SolidBrush(selectedForeColor), e.Bounds.Left + x, e.Bounds.Top + y);
            }
        }
    }
}
