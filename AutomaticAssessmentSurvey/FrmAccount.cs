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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AutomaticAssessmentSurvey
{
    public partial class FrmAccount : Form
    {
        private string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "account.txt");
        private Account account;
        

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "M5W4ZqFo90v3CjEokDbL95MwQ9bNa6IbNSoGFHIb",
            BasePath = "https://accountsinhvien-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public FrmAccount()
        {
            InitializeComponent();
            cboGioiTinh.DrawItem += new DrawItemEventHandler(cboGioiTinh_DrawItem);
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem", "Warning!");
            }

            account = new ControllerDataAccount(filePath).GetDataAccount();
            txtUser.Text = account.User;
            txtPassword.Text = account.Password;
            cboGioiTinh.Text = account.GioiTinh;

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
            if(txtUser.Text!="" &&  txtPassword.Text!="" && cboGioiTinh.Text!="")
            {
                new ControllerDataAccount(filePath).EditData(account);

                SetResponse set = client.Set(@"Users/" + txtUser.Text, account);
                MessageBox.Show("Lưu tài khoản thành công!");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin yêu cầu!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new ControllerDataAccount(filePath).DeleteData();
            FrmAccount_Load(sender, e);
            cboGioiTinh.Text = null;
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
