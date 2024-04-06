namespace AutomaticAssessmentSurvey
{
    partial class FrmCmt
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
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtKhen = new System.Windows.Forms.TextBox();
            this.txtChe = new System.Windows.Forms.TextBox();
            this.btnAddKhen = new FontAwesome.Sharp.IconButton();
            this.btnAddChe = new FontAwesome.Sharp.IconButton();
            this.txtListKhen = new System.Windows.Forms.RichTextBox();
            this.txtListChe = new System.Windows.Forms.RichTextBox();
            this.btnDelKhen = new FontAwesome.Sharp.IconButton();
            this.btnDelChe = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(276, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(331, 45);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Đánh giá mặc định";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(66, 361);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(170, 42);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Phê bình:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKhen
            // 
            this.txtKhen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKhen.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtKhen.Location = new System.Drawing.Point(242, 96);
            this.txtKhen.MaxLength = 200;
            this.txtKhen.Multiline = true;
            this.txtKhen.Name = "txtKhen";
            this.txtKhen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKhen.Size = new System.Drawing.Size(395, 65);
            this.txtKhen.TabIndex = 0;
            this.txtKhen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKhen_KeyDown);
            // 
            // txtChe
            // 
            this.txtChe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChe.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtChe.Location = new System.Drawing.Point(242, 361);
            this.txtChe.MaxLength = 200;
            this.txtChe.Multiline = true;
            this.txtChe.Name = "txtChe";
            this.txtChe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChe.Size = new System.Drawing.Size(395, 65);
            this.txtChe.TabIndex = 1;
            this.txtChe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChe_KeyDown);
            // 
            // btnAddKhen
            // 
            this.btnAddKhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKhen.ForeColor = System.Drawing.Color.White;
            this.btnAddKhen.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddKhen.IconColor = System.Drawing.Color.White;
            this.btnAddKhen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddKhen.IconSize = 40;
            this.btnAddKhen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddKhen.Location = new System.Drawing.Point(690, 96);
            this.btnAddKhen.Name = "btnAddKhen";
            this.btnAddKhen.Size = new System.Drawing.Size(127, 65);
            this.btnAddKhen.TabIndex = 2;
            this.btnAddKhen.Text = "Add";
            this.btnAddKhen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddKhen.UseVisualStyleBackColor = false;
            this.btnAddKhen.Click += new System.EventHandler(this.btnAddKhen_Click);
            // 
            // btnAddChe
            // 
            this.btnAddChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChe.ForeColor = System.Drawing.Color.White;
            this.btnAddChe.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddChe.IconColor = System.Drawing.Color.White;
            this.btnAddChe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddChe.IconSize = 40;
            this.btnAddChe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddChe.Location = new System.Drawing.Point(690, 361);
            this.btnAddChe.Name = "btnAddChe";
            this.btnAddChe.Size = new System.Drawing.Size(127, 65);
            this.btnAddChe.TabIndex = 4;
            this.btnAddChe.Text = "Add";
            this.btnAddChe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddChe.UseVisualStyleBackColor = false;
            this.btnAddChe.Click += new System.EventHandler(this.btnAddChe_Click);
            // 
            // txtListKhen
            // 
            this.txtListKhen.BackColor = System.Drawing.Color.MediumPurple;
            this.txtListKhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListKhen.ForeColor = System.Drawing.Color.White;
            this.txtListKhen.Location = new System.Drawing.Point(242, 167);
            this.txtListKhen.Name = "txtListKhen";
            this.txtListKhen.ReadOnly = true;
            this.txtListKhen.Size = new System.Drawing.Size(395, 134);
            this.txtListKhen.TabIndex = 14;
            this.txtListKhen.Text = "";
            // 
            // txtListChe
            // 
            this.txtListChe.BackColor = System.Drawing.Color.MediumPurple;
            this.txtListChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListChe.ForeColor = System.Drawing.Color.White;
            this.txtListChe.Location = new System.Drawing.Point(242, 432);
            this.txtListChe.Name = "txtListChe";
            this.txtListChe.ReadOnly = true;
            this.txtListChe.Size = new System.Drawing.Size(395, 134);
            this.txtListChe.TabIndex = 14;
            this.txtListChe.Text = "";
            // 
            // btnDelKhen
            // 
            this.btnDelKhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelKhen.ForeColor = System.Drawing.Color.White;
            this.btnDelKhen.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelKhen.IconColor = System.Drawing.Color.White;
            this.btnDelKhen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelKhen.IconSize = 40;
            this.btnDelKhen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelKhen.Location = new System.Drawing.Point(690, 236);
            this.btnDelKhen.Name = "btnDelKhen";
            this.btnDelKhen.Size = new System.Drawing.Size(127, 65);
            this.btnDelKhen.TabIndex = 3;
            this.btnDelKhen.Text = "Del";
            this.btnDelKhen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelKhen.UseVisualStyleBackColor = false;
            this.btnDelKhen.Click += new System.EventHandler(this.btnDelKhen_Click);
            // 
            // btnDelChe
            // 
            this.btnDelChe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelChe.ForeColor = System.Drawing.Color.White;
            this.btnDelChe.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelChe.IconColor = System.Drawing.Color.White;
            this.btnDelChe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelChe.IconSize = 40;
            this.btnDelChe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelChe.Location = new System.Drawing.Point(690, 501);
            this.btnDelChe.Name = "btnDelChe";
            this.btnDelChe.Size = new System.Drawing.Size(127, 65);
            this.btnDelChe.TabIndex = 5;
            this.btnDelChe.Text = "Del";
            this.btnDelChe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelChe.UseVisualStyleBackColor = false;
            this.btnDelChe.Click += new System.EventHandler(this.btnDelChe_Click);
            // 
            // FrmCmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.txtListChe);
            this.Controls.Add(this.txtListKhen);
            this.Controls.Add(this.btnAddChe);
            this.Controls.Add(this.btnDelChe);
            this.Controls.Add(this.btnDelKhen);
            this.Controls.Add(this.btnAddKhen);
            this.Controls.Add(this.txtChe);
            this.Controls.Add(this.txtKhen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "FrmCmt";
            this.Text = "FrmCmt";
            this.Load += new System.EventHandler(this.FrmCmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtKhen;
        private System.Windows.Forms.TextBox txtChe;
        private FontAwesome.Sharp.IconButton btnAddKhen;
        private FontAwesome.Sharp.IconButton btnAddChe;
        private System.Windows.Forms.RichTextBox txtListKhen;
        private System.Windows.Forms.RichTextBox txtListChe;
        private FontAwesome.Sharp.IconButton btnDelKhen;
        private FontAwesome.Sharp.IconButton btnDelChe;
    }
}