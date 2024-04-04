using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticAssessmentSurvey
{
    public partial class SurveyVote : UserControl
    {
        public SurveyVote()
        {
            InitializeComponent();
        }

        // Biến dùng để đổi tên TITLE cho GROUPBOX trong phần Properties
        private string _title;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; grbKhaoSat.Text = value; }
        }

        // Phương thức dùng để xác định đang chọn RADIO BUTTON nào
        public int RadChecked()
        {
            if (rad1.Checked)
                return 1;
            else if (rad2.Checked)
                return 2;
            else if (rad3.Checked)
                return 3;
            else if (rad4.Checked)
                return 4;
            else if (rad5.Checked)
                return 5;
            else return 0;
        }
    }
}
