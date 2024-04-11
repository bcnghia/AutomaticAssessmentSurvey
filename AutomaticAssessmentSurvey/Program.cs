using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticAssessmentSurvey
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong tiến trình hoạt động:\n• Kiểm tra lại kết nối Internet!" +
                    "\n• Kiểm tra lại thông tin đăng nhập - MSSV, mật khẩu" +
                    "\n• Cập nhật ứng dụng lên phiên bản mới nhất!",
                                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
                
            }
        }
    }
}
