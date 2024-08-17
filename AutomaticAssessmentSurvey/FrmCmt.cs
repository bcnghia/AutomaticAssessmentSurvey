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
    public partial class FrmCmt : Form
    {
        private string filePathKhen, filePathChe;
        private string cmtKhens, cmtChes;
        public FrmCmt()
        {
            InitializeComponent();

            string relativePath;

            relativePath = @"Resources\khen.txt";
            filePathKhen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            relativePath = @"Resources\phebinh.txt";
            filePathChe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
        }

        private void FrmCmt_Load(object sender, EventArgs e)
        {
            cmtKhens = new ControllerDataComment(filePathKhen).GetDataDisplay();
            cmtChes = new ControllerDataComment(filePathChe).GetDataDisplay();

            txtListKhen.Text = cmtKhens;
            txtListChe.Text = cmtChes;
            // đoạn này đang cấn là nó đang cùng 1 đoạn txt vậy thì khi mà viết code thì sẽ khó 
            // khăn khi mà nhiều đoạn cmt lại bị gọp thành 1 câu, tạm thời cứ để hiển thị như vậy,
            // chỉ cần tìm cách tách nó ra riêng để khi viết cmt sẽ tách ra thành từng câu random là được

            //if (cmtKhens != null )
            //{
            //    txtListKhen.Text = "- " + cmtKhens + "\n- ";
            //}
            //if (cmtChes != null)
            //{
            //    txtListChe.Text = "- " + cmtChes + "\n- ";
            //}

            //txtHDSD.Text = "NOTE:" +
            //               "\n\n- Nhập thông tin tài khoản vào và nhấn Save để sử dụng" +
            //               "\n\n- Trường hợp cần sửa thông tin thì sửa trực tiếp và nhấn Save" +
            //               "\n\n- Phần mềm lưu cùng lúc chỉ một tài khoản";
        }

        #region Thêm - xóa KHEN comment
        private void btnAddKhen_Click(object sender, EventArgs e)
        {
            if (txtKhen.Text != "")
            {
                new ControllerDataComment(filePathKhen).EditData(txtKhen.Text);
                txtKhen.Text = ""; // xóa dữ liệu đang nhập của text box hiện tại
                FrmCmt_Load(sender, e); // cập nhật lại list
            }
            else MessageBox.Show("Không hợp lệ!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnDelKhen_Click(object sender, EventArgs e)
        {
            new ControllerDataComment(filePathKhen).DeleteData();
            FrmCmt_Load(sender, e);
        }
        #endregion

        #region Thêm - xóa Chê comment
        private void btnAddChe_Click(object sender, EventArgs e)
        {
            if (txtChe.Text != "")
            {
                new ControllerDataComment(filePathChe).EditData(txtChe.Text);
                txtChe.Text = ""; // xóa dữ liệu đang nhập của text box hiện tại
                FrmCmt_Load(sender, e); // cập nhật lại list
            }
            else MessageBox.Show("Không hợp lệ!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnDelChe_Click(object sender, EventArgs e)
        {
            new ControllerDataComment(filePathChe).DeleteData();
            FrmCmt_Load(sender, e);
        }
        #endregion

        #region Sự kiện khi đang trong textbox mà nhấn Enter
        private void txtKhen_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter)){
                e.SuppressKeyPress = true;
                btnAddKhen.PerformClick();
            }
        }

        private void txtChe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
                btnAddChe.PerformClick();
            }
        }
        #endregion
    }
}
