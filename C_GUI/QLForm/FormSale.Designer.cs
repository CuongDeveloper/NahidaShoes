namespace C_GUI.QLForm
{
    partial class FormSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ptgiam = new C_GUI.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sotiengiam = new C_GUI.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngaybatdau = new C_GUI.RJControls.RJDatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_ngayketthuc = new C_GUI.RJControls.RJDatePicker();
            this.a = new System.Windows.Forms.GroupBox();
            this.dgrid_showsanpham = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_timkiemsale = new C_GUI.RJControls.RJTextBox();
            this.dgrid_SALE = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_timkiem = new C_GUI.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_giay = new FontAwesome.Sharp.IconButton();
            this.btn_suasale = new C_GUI.RJControls.RJButton();
            this.btn_themsale = new C_GUI.RJControls.RJButton();
            this.btn_xoasale = new C_GUI.RJControls.RJButton();
            this.cmb_sale = new C_GUI.RJControls.RJComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_giay = new C_GUI.RJControls.RJComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SALE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giảm Giá";
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
            this.btn_them.Location = new System.Drawing.Point(398, 19);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 29);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(398, 52);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 29);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_xoa.Location = new System.Drawing.Point(398, 96);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 29);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(571, 82);
            this.dgrid_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(698, 229);
            this.dgrid_show.TabIndex = 22;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
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
            this.txt_ma.Location = new System.Drawing.Point(118, 21);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(273, 27);
            this.txt_ma.TabIndex = 23;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
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
            this.txt_ten.Location = new System.Drawing.Point(118, 54);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(273, 27);
            this.txt_ten.TabIndex = 24;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
            // 
            // txt_ptgiam
            // 
            this.txt_ptgiam.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ptgiam.BorderColor = System.Drawing.Color.Black;
            this.txt_ptgiam.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ptgiam.BorderRadius = 15;
            this.txt_ptgiam.BorderSize = 2;
            this.txt_ptgiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ptgiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ptgiam.Location = new System.Drawing.Point(118, 87);
            this.txt_ptgiam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ptgiam.MaxLength = 20;
            this.txt_ptgiam.Multiline = false;
            this.txt_ptgiam.Name = "txt_ptgiam";
            this.txt_ptgiam.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ptgiam.PasswordChar = false;
            this.txt_ptgiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ptgiam.PlaceholderText = "";
            this.txt_ptgiam.Size = new System.Drawing.Size(273, 27);
            this.txt_ptgiam.TabIndex = 25;
            this.txt_ptgiam.Texts = "";
            this.txt_ptgiam.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Khuyến mại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "% Giảm Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số Tiền Giảm Giá";
            // 
            // txt_sotiengiam
            // 
            this.txt_sotiengiam.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sotiengiam.BorderColor = System.Drawing.Color.Black;
            this.txt_sotiengiam.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_sotiengiam.BorderRadius = 15;
            this.txt_sotiengiam.BorderSize = 2;
            this.txt_sotiengiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sotiengiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sotiengiam.Location = new System.Drawing.Point(118, 120);
            this.txt_sotiengiam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_sotiengiam.MaxLength = 20;
            this.txt_sotiengiam.Multiline = false;
            this.txt_sotiengiam.Name = "txt_sotiengiam";
            this.txt_sotiengiam.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_sotiengiam.PasswordChar = false;
            this.txt_sotiengiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_sotiengiam.PlaceholderText = "";
            this.txt_sotiengiam.Size = new System.Drawing.Size(273, 27);
            this.txt_sotiengiam.TabIndex = 30;
            this.txt_sotiengiam.Texts = "";
            this.txt_sotiengiam.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ngày Bắt Đầu";
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_ngaybatdau.BorderSize = 2;
            this.dtp_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(118, 165);
            this.dtp_ngaybatdau.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(200, 35);
            this.dtp_ngaybatdau.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_ngaybatdau.TabIndex = 34;
            this.dtp_ngaybatdau.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ngày kết Thúc";
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_ngayketthuc.BorderSize = 2;
            this.dtp_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(118, 222);
            this.dtp_ngayketthuc.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(200, 35);
            this.dtp_ngayketthuc.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtp_ngayketthuc.TabIndex = 36;
            this.dtp_ngayketthuc.TextColor = System.Drawing.Color.White;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a.Controls.Add(this.dgrid_showsanpham);
            this.a.Controls.Add(this.label12);
            this.a.Controls.Add(this.txt_timkiemsale);
            this.a.Controls.Add(this.dgrid_show);
            this.a.Controls.Add(this.dgrid_SALE);
            this.a.Controls.Add(this.label6);
            this.a.Controls.Add(this.txt_timkiem);
            this.a.Controls.Add(this.panel1);
            this.a.Controls.Add(this.panel2);
            this.a.Location = new System.Drawing.Point(-22, -35);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Size = new System.Drawing.Size(1289, 811);
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Text = "THÔNG TIN SIZE";
            this.a.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgrid_showsanpham
            // 
            this.dgrid_showsanpham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_showsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_showsanpham.Location = new System.Drawing.Point(354, 587);
            this.dgrid_showsanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_showsanpham.Name = "dgrid_showsanpham";
            this.dgrid_showsanpham.RowHeadersWidth = 51;
            this.dgrid_showsanpham.RowTemplate.Height = 29;
            this.dgrid_showsanpham.Size = new System.Drawing.Size(915, 192);
            this.dgrid_showsanpham.TabIndex = 56;
            this.dgrid_showsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_showsanpham_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(375, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 49;
            this.label12.Text = "tìm kiếm ";
            // 
            // txt_timkiemsale
            // 
            this.txt_timkiemsale.BackColor = System.Drawing.SystemColors.Window;
            this.txt_timkiemsale.BorderColor = System.Drawing.Color.Black;
            this.txt_timkiemsale.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_timkiemsale.BorderRadius = 15;
            this.txt_timkiemsale.BorderSize = 2;
            this.txt_timkiemsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiemsale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_timkiemsale.Location = new System.Drawing.Point(464, 375);
            this.txt_timkiemsale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timkiemsale.MaxLength = 20;
            this.txt_timkiemsale.Multiline = false;
            this.txt_timkiemsale.Name = "txt_timkiemsale";
            this.txt_timkiemsale.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_timkiemsale.PasswordChar = false;
            this.txt_timkiemsale.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timkiemsale.PlaceholderText = "";
            this.txt_timkiemsale.Size = new System.Drawing.Size(348, 27);
            this.txt_timkiemsale.TabIndex = 48;
            this.txt_timkiemsale.Texts = "";
            this.txt_timkiemsale.UnderlinedStyle = false;
            this.txt_timkiemsale._TextChanged += new System.EventHandler(this.txt_timkiemsale__TextChanged);
            // 
            // dgrid_SALE
            // 
            this.dgrid_SALE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_SALE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SALE.Location = new System.Drawing.Point(354, 413);
            this.dgrid_SALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_SALE.Name = "dgrid_SALE";
            this.dgrid_SALE.RowHeadersWidth = 51;
            this.dgrid_SALE.RowTemplate.Height = 29;
            this.dgrid_SALE.Size = new System.Drawing.Size(915, 160);
            this.dgrid_SALE.TabIndex = 39;
            this.dgrid_SALE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SALE_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(582, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "tìm kiếm sale";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_timkiem.BorderColor = System.Drawing.Color.Black;
            this.txt_timkiem.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_timkiem.BorderRadius = 15;
            this.txt_timkiem.BorderSize = 2;
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_timkiem.Location = new System.Drawing.Point(670, 50);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timkiem.MaxLength = 20;
            this.txt_timkiem.Multiline = false;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_timkiem.PasswordChar = false;
            this.txt_timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timkiem.PlaceholderText = "";
            this.txt_timkiem.Size = new System.Drawing.Size(242, 27);
            this.txt_timkiem.TabIndex = 37;
            this.txt_timkiem.Texts = "";
            this.txt_timkiem.UnderlinedStyle = false;
            this.txt_timkiem._TextChanged += new System.EventHandler(this.txt_timkiem__TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.dtp_ngayketthuc);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp_ngaybatdau);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_ma);
            this.panel1.Controls.Add(this.txt_sotiengiam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ptgiam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 264);
            this.panel1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "QL sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_giay);
            this.panel2.Controls.Add(this.btn_suasale);
            this.panel2.Controls.Add(this.btn_themsale);
            this.panel2.Controls.Add(this.btn_xoasale);
            this.panel2.Controls.Add(this.cmb_sale);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmb_giay);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(29, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 376);
            this.panel2.TabIndex = 47;
            // 
            // btn_giay
            // 
            this.btn_giay.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_giay.IconColor = System.Drawing.Color.Black;
            this.btn_giay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_giay.IconSize = 30;
            this.btn_giay.Location = new System.Drawing.Point(287, 92);
            this.btn_giay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giay.Name = "btn_giay";
            this.btn_giay.Size = new System.Drawing.Size(28, 25);
            this.btn_giay.TabIndex = 57;
            this.btn_giay.UseVisualStyleBackColor = true;
            this.btn_giay.Click += new System.EventHandler(this.btn_giay_Click);
            // 
            // btn_suasale
            // 
            this.btn_suasale.BackColor = System.Drawing.Color.Turquoise;
            this.btn_suasale.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_suasale.BorderColor = System.Drawing.Color.Black;
            this.btn_suasale.BorderRadius = 15;
            this.btn_suasale.BorderSize = 2;
            this.btn_suasale.FlatAppearance.BorderSize = 0;
            this.btn_suasale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suasale.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_suasale.ForeColor = System.Drawing.Color.Black;
            this.btn_suasale.Location = new System.Drawing.Point(15, 227);
            this.btn_suasale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_suasale.Name = "btn_suasale";
            this.btn_suasale.Size = new System.Drawing.Size(266, 72);
            this.btn_suasale.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_suasale.TabIndex = 43;
            this.btn_suasale.Text = "Sửa";
            this.btn_suasale.TextColor = System.Drawing.Color.Black;
            this.btn_suasale.UseVisualStyleBackColor = false;
            this.btn_suasale.Click += new System.EventHandler(this.btn_suasale_Click);
            // 
            // btn_themsale
            // 
            this.btn_themsale.BackColor = System.Drawing.Color.Turquoise;
            this.btn_themsale.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_themsale.BorderColor = System.Drawing.Color.Black;
            this.btn_themsale.BorderRadius = 15;
            this.btn_themsale.BorderSize = 2;
            this.btn_themsale.FlatAppearance.BorderSize = 0;
            this.btn_themsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themsale.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_themsale.ForeColor = System.Drawing.Color.Black;
            this.btn_themsale.Location = new System.Drawing.Point(15, 153);
            this.btn_themsale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themsale.Name = "btn_themsale";
            this.btn_themsale.Size = new System.Drawing.Size(266, 70);
            this.btn_themsale.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_themsale.TabIndex = 42;
            this.btn_themsale.Text = "Thêm";
            this.btn_themsale.TextColor = System.Drawing.Color.Black;
            this.btn_themsale.UseVisualStyleBackColor = false;
            this.btn_themsale.Click += new System.EventHandler(this.btn_themsale_Click);
            // 
            // btn_xoasale
            // 
            this.btn_xoasale.BackColor = System.Drawing.Color.Turquoise;
            this.btn_xoasale.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_xoasale.BorderColor = System.Drawing.Color.Black;
            this.btn_xoasale.BorderRadius = 15;
            this.btn_xoasale.BorderSize = 2;
            this.btn_xoasale.FlatAppearance.BorderSize = 0;
            this.btn_xoasale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoasale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoasale.ForeColor = System.Drawing.Color.Black;
            this.btn_xoasale.Location = new System.Drawing.Point(14, 303);
            this.btn_xoasale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoasale.Name = "btn_xoasale";
            this.btn_xoasale.Size = new System.Drawing.Size(266, 63);
            this.btn_xoasale.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoasale.TabIndex = 44;
            this.btn_xoasale.Text = "Xóa";
            this.btn_xoasale.TextColor = System.Drawing.Color.Black;
            this.btn_xoasale.UseVisualStyleBackColor = false;
            this.btn_xoasale.Click += new System.EventHandler(this.btn_xoasale_Click);
            // 
            // cmb_sale
            // 
            this.cmb_sale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_sale.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_sale.BorderSize = 1;
            this.cmb_sale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_sale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_sale.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_sale.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_sale.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_sale.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_sale.Location = new System.Drawing.Point(81, 33);
            this.cmb_sale.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_sale.Name = "cmb_sale";
            this.cmb_sale.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_sale.Size = new System.Drawing.Size(200, 30);
            this.cmb_sale.TabIndex = 41;
            this.cmb_sale.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(14, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Tên Giày";
            // 
            // cmb_giay
            // 
            this.cmb_giay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_giay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_giay.BorderSize = 1;
            this.cmb_giay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_giay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_giay.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_giay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_giay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_giay.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_giay.Location = new System.Drawing.Point(81, 86);
            this.cmb_giay.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_giay.Name = "cmb_giay";
            this.cmb_giay.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_giay.Size = new System.Drawing.Size(200, 31);
            this.cmb_giay.TabIndex = 42;
            this.cmb_giay.Texts = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tên Sale";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 766);
            this.Controls.Add(this.a);
            this.Name = "FormSale";
            this.Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SALE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
        private DataGridView dgrid_show;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ptgiam;
        private Label label2;
        private Label label3;
        private Label label5;
        private RJControls.RJTextBox txt_sotiengiam;
        private Label label7;
        private RJControls.RJDatePicker dtp_ngaybatdau;
        private Label label8;
        private RJControls.RJDatePicker dtp_ngayketthuc;
        private GroupBox a;
        private RJControls.RJTextBox txt_timkiem;
        private Label label6;
        private DataGridView dgrid_SALE;
        private Panel panel1;
        private Label label4;
        private Label label10;
        private Label label9;
        private RJControls.RJComboBox cmb_giay;
        private RJControls.RJComboBox cmb_sale;
        private Panel panel2;
        private Label label12;
        private RJControls.RJTextBox txt_timkiemsale;
        private RJControls.RJButton btn_suasale;
        private RJControls.RJButton btn_themsale;
        private RJControls.RJButton btn_xoasale;
        private DataGridView dgrid_showsanpham;
        private FontAwesome.Sharp.IconButton btn_giay;
    }
}