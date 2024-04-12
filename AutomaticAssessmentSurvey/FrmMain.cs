using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using FontAwesome.Sharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;
using System.Threading;
using AutomaticAssessmentSurvey;
using System.Net.NetworkInformation;

namespace AutomaticAssessmentSurvey
{
    public partial class FrmMain : Form
    {
        private string filePath = System.IO.Path.Combine(AppContext.BaseDirectory, "Data", "account.txt");
        private string filePathKhen = System.IO.Path.Combine(AppContext.BaseDirectory, "Data", "khen.txt");
        private string filePathChe = System.IO.Path.Combine(AppContext.BaseDirectory, "Data", "phebinh.txt");
        private IconButton clickBtn;
        private Form activeForm;
        private Account account;

        private ChromeDriverService service;
        private IWebDriver driver;
        public FrmMain()
        {
            InitializeComponent();

            // Gắn sự kiện ValueChanged với phương thức
            nudSoLuongKhaoSat.ValueChanged += nudSoLuongKhaoSat_ValueChanged;

            // Khởi tạo ChromeDriverService để ẩn cửa sổ cmd hiện lên
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            account = new ControllerDataAccount(filePath).GetDataAccount();
            txtHDSD.Text = "NOTE: Quan trọng nhắc 3 lần" +
                           "\n\n- DEV không viết bẫy lỗi => Thêm đúng số lượng khảo sát cần đánh giá" +
                           "\n- DEV không viết bẫy lỗi => Thêm đúng số lượng khảo sát cần đánh giá" +
                           "\n- DEV không viết bẫy lỗi => Thêm đúng số lượng khảo sát cần đánh giá";

            btnHome.BackColor = Color.White;
            btnHome.ForeColor = Color.DarkSlateBlue;
            btnHome.IconColor = Color.DarkSlateBlue;
            btnHome.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 163);
        }

        #region EVENT WinForm
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Khi Form đóng, trình duyệt cũng được tắt để giải phóng tài nguyên
            if (driver != null)
                driver.Quit();
        }

        private int startVlue = 0;
        private void nudSoLuongKhaoSat_ValueChanged(object sender, EventArgs e)
        {
            int nowValue = (int)nudSoLuongKhaoSat.Value;
            if (nowValue > startVlue)
            {
                // Tăng giá trị của NumericUpDown, thêm SurveyVote tương ứng
                for (int i = startVlue + 1; i <= nowValue; i++)
                {
                    SurveyVote suv = new SurveyVote();
                    suv.Title = "Khảo sát " + i;
                    suv.AutoSize = true;

                    fpnlDesktop.Controls.Add(suv);
                }
            }
            else if (nowValue < startVlue)
            {
                // Giảm giá trị của NumericUpDown, xóa SurveyVote thừa
                for (int i = fpnlDesktop.Controls.Count - 1; i >= nowValue; i--)
                    fpnlDesktop.Controls.RemoveAt(i);
            }

            startVlue = nowValue;
        }
        #endregion

        #region GENERAL FUNCTION
        private void Login()
        {
            if (driver != null)
                driver.Quit();
            account = new ControllerDataAccount(filePath).GetDataAccount();

            driver = new ChromeDriver(service);
            driver.Manage().Window.Maximize();
            driver.Url = "https://sv.bdu.edu.vn/#/home";
            // Delay để trang web load dữ liệu
            Thread.Sleep(5000);

            // Tìm nhập username và password
            IWebElement user = driver.FindElement(By.CssSelector("[formcontrolname='username']"));
            user.SendKeys(account.User);
            IWebElement password = driver.FindElement(By.CssSelector("[formcontrolname='password']"));
            password.SendKeys(account.Password);

            // Tìm - Click "Đăng nhập" để đăng nhập vào tài khoản
            IWebElement login = driver.FindElement(By.XPath("//button[contains(text(), 'Đăng nhập')]"));
            login.Click();
            Thread.Sleep(2000);
        }

        private void ClickJavaScript(string nameButton)
        {
            IWebElement element = driver.FindElement(By.LinkText(nameButton));
            IJavaScriptExecutor jsExcutor = (IJavaScriptExecutor)driver;
            jsExcutor.ExecuteScript("arguments[0].click();", element);
        }

        private void ClickKhaoSat(int idKhaoSat)
        {
            IWebElement khaoSat = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-dgmain/div/div[2]/div/div/table/tbody/tr[2]/td[2]/div/table/tbody/tr[{idKhaoSat +1}]/td[1]"));
            //khaoSat.Click();
            Thread.Sleep(100);
            IJavaScriptExecutor jsExcutor = (IJavaScriptExecutor)driver;
            jsExcutor.ExecuteScript("arguments[0].click();", khaoSat);
        }

        private bool CheckingConnection()
        {
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn");
            //Console.WriteLine(pingReply.Status);
            if (pingReply.Status == IPStatus.Success) return true;
            else return false;
        }

        private void ThucHienKhaoSat(SurveyVote suv)
        {
            // NOTE:
            // QUY TẮC TRÁNH PHÁT SINH LỖI TRONG ĐOẠN CODE NÀY
            // trước mỗi lần nhấn click thì để cho hệ thống ngủ vài giây để load, dù đã có sẵn màn hình vẫn chờ để load
            // mỗi phần đánh giá riêng cần đưa vào 1 REGION riêng để dễ quản lý và sửa lỗi trong tương lai
            // Lưu ý có một mục div trong XPath phải tự cộng thêm 1 để có thể truy cập đúng nút cần nhấn
            IWebElement element;
            IJavaScriptExecutor jsExcutor = (IJavaScriptExecutor)driver;
            Thread.Sleep(1000);

            #region Thông tin 1 - Giới Tính
            if (account.GioiTinh == "Nam")
                element = driver.FindElement(By.XPath("/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[3]/app-child-ksdg-thangdo/div[2]/div/div/table/tbody/tr[2]/td/div[1]/input"));
            else
                element = driver.FindElement(By.XPath("/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[3]/app-child-ksdg-thangdo/div[2]/div/div/table/tbody/tr[2]/td/div[2]/input"));
            
            Thread.Sleep(100);
            //element.Click();
            jsExcutor.ExecuteScript("arguments[0].click();", element);
            #endregion

            #region Thông tin 2 - Tỷ lệ thời gian tham gia lớp học
            // đang mặc định chọn "Trên 80%"
            element = driver.FindElement(By.XPath("/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[4]/app-child-ksdg-thangdo/div[2]/div/div/table/tbody/tr[2]/td/div[1]/input"));

            Thread.Sleep(100);
            //element.Click();
            jsExcutor.ExecuteScript("arguments[0].click();", element);
            #endregion

            #region I. Thông tin về môn học và tài liệu giảng dạy
            for (int i = 1; i <= 5; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[5]/app-child-ksdg-thangdo/div[3]/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                //element.Click();
                // Đoạn này Click() thông thường bị chặn nên phải sử dụng JavaScript để Click
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region II. Phương pháp giảng dạy của giảng viên
            for (int i = 1; i <= 6; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[6]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region III. Nội dung giảng dạy
            for (int i = 1; i <= 6; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[7]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region IV. Kiểm tra đánh giá
            for (int i = 1; i <= 6; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[8]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region V. Tác phong sư phạm
            for (int i = 1; i <= 6; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[9]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region VI. Đánh giá về chương trình đào tạo (mặc định là 3)
            for (int i = 1; i <= 4; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[10]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + 3}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region VII. Cảm nhận chung về học phần
            for (int i = 1; i <= 2; i++)
            {
                element = driver.FindElement(By.XPath($"/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[2]/div/div[11]/app-child-ksdg-thangdo/div/div/table/tbody[{i}]/tr/td[{2 + suv.RadChecked()}]/input"));

                Thread.Sleep(100);
                jsExcutor.ExecuteScript("arguments[0].click();", element);
            }
            #endregion

            #region VIII. Ý kiến khác
            // 38. Những ưu điểm nổi bật của giảng viên trong quá trình giảng dạy học phần
            element = driver.FindElement(By.Id("38"));
            if (suv.RadChecked() <= 3)
            {
                Thread.Sleep(100);
                element.SendKeys(new ControllerDataComment(filePathChe).GetComment());
            } else
            {
                Thread.Sleep(100);
                element.SendKeys(new ControllerDataComment(filePathKhen).GetComment());
            }

            // 39. Những điều anh/chị chưa hài lòng về môn học này
            element = driver.FindElement(By.Id("39")); // Đây là mục mặc định
            if (suv.RadChecked() <= 3)
            {
                Thread.Sleep(100);
                element.SendKeys("Không có nhiều sự lựa chọn về giảng viên giảng dạy."); // mặc định
            }
            else
            {
                Thread.Sleep(100);
                element.SendKeys("Không.");
            }
            // 40. Đề xuất của Anh/Chị để việc giảng dạy môn học này được tốt hơn: Góp ý cho Giảng viên
            element = driver.FindElement(By.Id("40"));
            if (suv.RadChecked() <= 3)
            {
                Thread.Sleep(100);
                element.SendKeys(new ControllerDataComment(filePathChe).GetComment());
            }
            else
            {
                Thread.Sleep(100);
                element.SendKeys(new ControllerDataComment(filePathKhen).GetComment());
            }
            // 41. Đề xuất của Anh/Chị để việc giảng dạy môn học này được tốt hơn: Góp ý cho Nhà trường
            element = driver.FindElement(By.Id("41"));
            if (suv.RadChecked() <= 2)
            {
                Thread.Sleep(100);
                element.SendKeys("Mong trường nhắc nhở giảng viên để xem lại phương pháp giảng dạy.");
            }
            else
            {
                Thread.Sleep(100);
                element.SendKeys("Không.");
            }
            #endregion

            #region Gửi
            element = driver.FindElement(By.XPath("/html/body/app-root/div/div/div/div[1]/div/div/div[1]/app-ksdg-cauhoi/div/div[3]/button[2]"));
            Thread.Sleep(100);
            jsExcutor.ExecuteScript("arguments[0].click();", element);
            #endregion
        }
        #endregion

        #region OPEN FORM
        private void OpenHomeChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            // false giúp form nhúng vào CONTROL PANEL
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                // Kiểm tra xem có Form nào đang mở thì đóng lại
                activeForm.Close();
            }
            EnableButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            // false giúp form nhúng vào CONTROL PANEL
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region ENABLE BUTTON
        private void EnableButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (clickBtn != (IconButton)btnSender)
                {
                    DisableButton();
                    clickBtn = (IconButton)btnSender;
                    clickBtn.BackColor = Color.White;
                    clickBtn.ForeColor = Color.DarkSlateBlue;
                    clickBtn.IconColor = Color.DarkSlateBlue;
                    clickBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point,163);
                }
            }
        }
        private void DisableButton()
        {
            foreach (IconButton resetBtn in pnlMenu.Controls.OfType<IconButton>())
            {
                resetBtn.BackColor = Color.DarkSlateBlue;
                resetBtn.ForeColor = Color.White;
                resetBtn.IconColor = Color.White;
                resetBtn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            }
        }
        #endregion

        #region CLICK BUTTON
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            EnableButton(sender);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAccount(), sender);
        }
        private void btnCmt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCmt(),sender);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckingConnection())
            {
                try
                {
                    LogicRunSurveyVote();
                }
                catch (Exception ex)
                {
                    driver.Quit();
                    MessageBox.Show("Vui lòng trở lại khi có khảo sát mới",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            if (CheckingConnection())
            {
                Login();

                // Tìm - Click vào link cần chọn
                ClickJavaScript("Xem thời khóa biểu tuần");
            }
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            if (CheckingConnection() )
            {
                Login();

                // Tìm - Click vào link cần chọn
                ClickJavaScript("Xem lịch thi");
            }
        }
        #endregion

        #region LOGIC KHẢO SÁT ĐÁNH GIÁ

        // Kiểm tra - làm việc với từng SurveyVote
        private void LogicRunSurveyVote()
        {
            List<SurveyVote> suvList = new List<SurveyVote>();
            for (int i = 0; i < fpnlDesktop.Controls.Count; i++)
            {
                Control control = fpnlDesktop.Controls[i];
                if (control is SurveyVote suv)
                {
                    suvList.Add(suv);
                }
            }

            // Kiểm tra toàn bộ đều đã được VOTE mới thoát vòng lặp, không thì RETURN
            foreach (SurveyVote suv in suvList)
            {
                if (suv.RadChecked() == 0)
                {
                    MessageBox.Show("Vui lòng VOTE đủ các khảo sát!");
                    return;
                }
            }

            if (suvList.Count == 0)
            {
                MessageBox.Show("Danh sách khảo sát (trống)!");
                return;
            }

            Login();

            // Thực hiện khảo sát đánh giá - mở các khảo sát và đánh giá
            int count = 0;
            foreach (SurveyVote suv in suvList)
            {
                // vào trang khảo sát đánh giá
                ClickJavaScript("Khảo sát đánh giá");

                // đợi màn hình load lên danh sách khảo sát đánh giá hiện có
                Thread.Sleep(2000);

                // tăng số thự tự của khảo sát lên
                count++; 

                // chọn vào khảo sát dựa trên số thứ tự của khảo sát
                ClickKhaoSat(count);

                // đợi màn hình load lên Form của khảo sát vừa click
                Thread.Sleep(1000);

                // Thực hiện điền form khảo sát
                ThucHienKhaoSat(suv);

                rtxtProgress.Text += "\n• Điểm Vote " + suv.Title + ": " + suv.RadChecked();
                fpnlDesktop.Controls.Remove(suv);
                // Dù vòng lặp duyệt qua List nhưng REMOVE dùng fpnlDesktop nên vẫn sẽ xóa được
                nudSoLuongKhaoSat.Value = nudSoLuongKhaoSat.Value - 1;
            }

        }
        #endregion
    }
}