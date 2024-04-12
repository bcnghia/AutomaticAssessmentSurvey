namespace AutomaticAssessmentSurvey
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnData = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCmt = new FontAwesome.Sharp.IconButton();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.rtxtProgress = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudSoLuongKhaoSat = new System.Windows.Forms.NumericUpDown();
            this.txtHDSD = new System.Windows.Forms.RichTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.fpnlDesktop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLichThi = new FontAwesome.Sharp.IconButton();
            this.btnTKB = new FontAwesome.Sharp.IconButton();
            this.btnRun = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhaoSat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(247, 142);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnData
            // 
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnData.IconColor = System.Drawing.Color.White;
            this.btnData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(0, 142);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(247, 142);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "ACCOUNT";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMenu.Controls.Add(this.btnCmt);
            this.pnlMenu.Controls.Add(this.btnData);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(247, 702);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCmt
            // 
            this.btnCmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCmt.FlatAppearance.BorderSize = 0;
            this.btnCmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCmt.ForeColor = System.Drawing.Color.White;
            this.btnCmt.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnCmt.IconColor = System.Drawing.Color.White;
            this.btnCmt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCmt.Location = new System.Drawing.Point(0, 284);
            this.btnCmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCmt.Name = "btnCmt";
            this.btnCmt.Size = new System.Drawing.Size(247, 142);
            this.btnCmt.TabIndex = 2;
            this.btnCmt.Text = "COMMENT";
            this.btnCmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCmt.UseVisualStyleBackColor = true;
            this.btnCmt.Click += new System.EventHandler(this.btnCmt_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.rtxtProgress);
            this.pnlDesktop.Controls.Add(this.panel1);
            this.pnlDesktop.Controls.Add(this.fpnlDesktop);
            this.pnlDesktop.Controls.Add(this.btnLichThi);
            this.pnlDesktop.Controls.Add(this.btnTKB);
            this.pnlDesktop.Controls.Add(this.btnRun);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(247, 0);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(934, 702);
            this.pnlDesktop.TabIndex = 1;
            // 
            // rtxtProgress
            // 
            this.rtxtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxtProgress.ForeColor = System.Drawing.Color.SlateBlue;
            this.rtxtProgress.Location = new System.Drawing.Point(400, 610);
            this.rtxtProgress.Name = "rtxtProgress";
            this.rtxtProgress.ReadOnly = true;
            this.rtxtProgress.Size = new System.Drawing.Size(346, 68);
            this.rtxtProgress.TabIndex = 8;
            this.rtxtProgress.Text = "Tiến trình:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudSoLuongKhaoSat);
            this.panel1.Controls.Add(this.txtHDSD);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 100);
            this.panel1.TabIndex = 7;
            // 
            // nudSoLuongKhaoSat
            // 
            this.nudSoLuongKhaoSat.BackColor = System.Drawing.Color.SlateBlue;
            this.nudSoLuongKhaoSat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSoLuongKhaoSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuongKhaoSat.ForeColor = System.Drawing.Color.White;
            this.nudSoLuongKhaoSat.Location = new System.Drawing.Point(296, 31);
            this.nudSoLuongKhaoSat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoLuongKhaoSat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoLuongKhaoSat.Name = "nudSoLuongKhaoSat";
            this.nudSoLuongKhaoSat.ReadOnly = true;
            this.nudSoLuongKhaoSat.Size = new System.Drawing.Size(53, 45);
            this.nudSoLuongKhaoSat.TabIndex = 9;
            // 
            // txtHDSD
            // 
            this.txtHDSD.BackColor = System.Drawing.Color.SlateBlue;
            this.txtHDSD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHDSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHDSD.ForeColor = System.Drawing.Color.White;
            this.txtHDSD.Location = new System.Drawing.Point(379, 2);
            this.txtHDSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.ReadOnly = true;
            this.txtHDSD.Size = new System.Drawing.Size(532, 97);
            this.txtHDSD.TabIndex = 7;
            this.txtHDSD.Text = "";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(3, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(287, 41);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Số lượng khảo sát";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpnlDesktop
            // 
            this.fpnlDesktop.AutoScroll = true;
            this.fpnlDesktop.Location = new System.Drawing.Point(5, 119);
            this.fpnlDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fpnlDesktop.Name = "fpnlDesktop";
            this.fpnlDesktop.Size = new System.Drawing.Size(915, 486);
            this.fpnlDesktop.TabIndex = 6;
            // 
            // btnLichThi
            // 
            this.btnLichThi.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichThi.ForeColor = System.Drawing.Color.White;
            this.btnLichThi.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnLichThi.IconColor = System.Drawing.Color.White;
            this.btnLichThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLichThi.IconSize = 40;
            this.btnLichThi.Location = new System.Drawing.Point(215, 610);
            this.btnLichThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichThi.Name = "btnLichThi";
            this.btnLichThi.Size = new System.Drawing.Size(157, 68);
            this.btnLichThi.TabIndex = 5;
            this.btnLichThi.Text = "Lịch Thi";
            this.btnLichThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichThi.UseVisualStyleBackColor = false;
            this.btnLichThi.Click += new System.EventHandler(this.btnLichThi_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTKB.ForeColor = System.Drawing.Color.White;
            this.btnTKB.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnTKB.IconColor = System.Drawing.Color.White;
            this.btnTKB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKB.IconSize = 40;
            this.btnTKB.Location = new System.Drawing.Point(28, 610);
            this.btnTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(157, 68);
            this.btnTKB.TabIndex = 5;
            this.btnTKB.Text = "TKB";
            this.btnTKB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKB.UseVisualStyleBackColor = false;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.btnRun.IconColor = System.Drawing.Color.White;
            this.btnRun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRun.IconSize = 55;
            this.btnRun.Location = new System.Drawing.Point(763, 610);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(157, 68);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Vote";
            this.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1181, 702);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1199, 749);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TỰ ĐỘNG ĐÁNH GIÁ KHẢO SÁT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongKhaoSat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnData;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.FlowLayoutPanel fpnlDesktop;
        private FontAwesome.Sharp.IconButton btnRun;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTKB;
        private System.Windows.Forms.NumericUpDown nudSoLuongKhaoSat;
        private System.Windows.Forms.RichTextBox txtHDSD;
        private System.Windows.Forms.Label lblUser;
        private FontAwesome.Sharp.IconButton btnLichThi;
        private System.Windows.Forms.RichTextBox rtxtProgress;
        private FontAwesome.Sharp.IconButton btnCmt;
    }
}

