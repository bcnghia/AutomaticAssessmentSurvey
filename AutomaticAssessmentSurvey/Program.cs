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
                MessageBox.Show("Vui lòng cập nhật ứng dụng lên phiên bản mới nhất!",
                                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
