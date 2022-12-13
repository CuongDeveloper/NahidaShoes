namespace C_GUI.QLForm
{
    partial class FormKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.cbx_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.cbx_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.txt_email = new C_GUI.RJControls.RJTextBox();
            this.txt_diachi = new C_GUI.RJControls.RJTextBox();
            this.dtt_ngaysinh = new C_GUI.RJControls.RJDatePicker();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.txt_sdt = new System.Windows.Forms.MaskedTextBox();
            this.dgrid_showKhachHang = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_socccd = new C_GUI.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_socccd);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.cbx_khonghoatdong);
            this.groupBox1.Controls.Add(this.cbx_hoatdong);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.dtt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.dgrid_showKhachHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 2;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(682, 418);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 43;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 2;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(530, 418);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 42;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Turquoise;
            this.btn_them.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_them.BorderColor = System.Drawing.Color.Black;
            this.btn_them.BorderRadius = 15;
            this.btn_them.BorderSize = 2;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(392, 418);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(132, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 41;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cbx_khonghoatdong
            // 
            this.cbx_khonghoatdong.AutoSize = true;
            this.cbx_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.cbx_khonghoatdong.Location = new System.Drawing.Point(205, 433);
            this.cbx_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbx_khonghoatdong.Name = "cbx_khonghoatdong";
            this.cbx_khonghoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbx_khonghoatdong.Size = new System.Drawing.Size(156, 24);
            this.cbx_khonghoatdong.TabIndex = 40;
            this.cbx_khonghoatdong.TabStop = true;
            this.cbx_khonghoatdong.Text = "Không hoạt động";
            this.cbx_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.cbx_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // cbx_hoatdong
            // 
            this.cbx_hoatdong.AutoSize = true;
            this.cbx_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.cbx_hoatdong.Location = new System.Drawing.Point(205, 377);
            this.cbx_hoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbx_hoatdong.Name = "cbx_hoatdong";
            this.cbx_hoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbx_hoatdong.Size = new System.Drawing.Size(112, 24);
            this.cbx_hoatdong.TabIndex = 39;
            this.cbx_hoatdong.TabStop = true;
            this.cbx_hoatdong.Text = "Hoạt động";
            this.cbx_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.cbx_hoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderColor = System.Drawing.Color.Black;
            this.txt_email.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_email.BorderRadius = 15;
            this.txt_email.BorderSize = 2;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.Location = new System.Drawing.Point(884, 155);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.MaxLength = 20;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_email.PasswordChar = false;
            this.txt_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email.PlaceholderText = "";
            this.txt_email.Size = new System.Drawing.Size(250, 35);
            this.txt_email.TabIndex = 13;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_diachi.BorderColor = System.Drawing.Color.Black;
            this.txt_diachi.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_diachi.BorderRadius = 15;
            this.txt_diachi.BorderSize = 2;
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_diachi.Location = new System.Drawing.Point(884, 53);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.MaxLength = 20;
            this.txt_diachi.Multiline = false;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_diachi.PasswordChar = false;
            this.txt_diachi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_diachi.PlaceholderText = "";
            this.txt_diachi.Size = new System.Drawing.Size(250, 35);
            this.txt_diachi.TabIndex = 12;
            this.txt_diachi.Texts = "";
            this.txt_diachi.UnderlinedStyle = false;
            // 
            // dtt_ngaysinh
            // 
            this.dtt_ngaysinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtt_ngaysinh.BorderSize = 2;
            this.dtt_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtt_ngaysinh.Location = new System.Drawing.Point(205, 261);
            this.dtt_ngaysinh.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dtt_ngaysinh.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtt_ngaysinh.Name = "dtt_ngaysinh";
            this.dtt_ngaysinh.Size = new System.Drawing.Size(250, 35);
            this.dtt_ngaysinh.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtt_ngaysinh.TabIndex = 11;
            this.dtt_ngaysinh.TextColor = System.Drawing.Color.White;
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ten.BorderColor = System.Drawing.Color.Black;
            this.txt_ten.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ten.BorderRadius = 15;
            this.txt_ten.BorderSize = 2;
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ten.Location = new System.Drawing.Point(205, 155);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(250, 35);
            this.txt_ten.TabIndex = 10;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
            // 
            // txt_ma
            // 
            this.txt_ma.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ma.BorderColor = System.Drawing.Color.Black;
            this.txt_ma.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ma.BorderRadius = 15;
            this.txt_ma.BorderSize = 2;
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ma.Location = new System.Drawing.Point(205, 53);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(250, 35);
            this.txt_ma.TabIndex = 9;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(884, 268);
            this.txt_sdt.Mask = "(999) 000-0000";
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(250, 27);
            this.txt_sdt.TabIndex = 8;
            // 
            // dgrid_showKhachHang
            // 
            this.dgrid_showKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrid_showKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_showKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_showKhachHang.Location = new System.Drawing.Point(3, 566);
            this.dgrid_showKhachHang.Name = "dgrid_showKhachHang";
            this.dgrid_showKhachHang.RowHeadersWidth = 51;
            this.dgrid_showKhachHang.RowTemplate.Height = 29;
            this.dgrid_showKhachHang.Size = new System.Drawing.Size(1191, 164);
            this.dgrid_showKhachHang.TabIndex = 7;
            this.dgrid_showKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_showKhachHang_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // tbx_socccd
            // 
            this.tbx_socccd.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_socccd.BorderColor = System.Drawing.Color.Black;
            this.tbx_socccd.BorderFocusColor = System.Drawing.Color.Red;
            this.tbx_socccd.BorderRadius = 15;
            this.tbx_socccd.BorderSize = 2;
            this.tbx_socccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_socccd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_socccd.Location = new System.Drawing.Point(884, 336);
            this.tbx_socccd.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_socccd.MaxLength = 20;
            this.tbx_socccd.Multiline = false;
            this.tbx_socccd.Name = "tbx_socccd";
            this.tbx_socccd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbx_socccd.PasswordChar = false;
            this.tbx_socccd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbx_socccd.PlaceholderText = "";
            this.tbx_socccd.Size = new System.Drawing.Size(250, 35);
            this.tbx_socccd.TabIndex = 44;
            this.tbx_socccd.Texts = "";
            this.tbx_socccd.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Số CCCD";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 765);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RJControls.RJTextBox txt_email;
        private RJControls.RJTextBox txt_diachi;
        private RJControls.RJDatePicker dtt_ngaysinh;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ma;
        private MaskedTextBox txt_sdt;
        private DataGridView dgrid_showKhachHang;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RJControls.RJRadioButton cbx_hoatdong;
        private RJControls.RJRadioButton cbx_khonghoatdong;
        private RJControls.RJButton btn_xoa;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_them;
        private Label label8;
        private RJControls.RJTextBox tbx_socccd;
    }
}