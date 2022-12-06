namespace C_GUI.Views
{
    partial class FormBestSeller
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
            this.grb_hide = new System.Windows.Forms.GroupBox();
            this.dgrid_ss = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lbllockhoang = new System.Windows.Forms.Label();
            this.lab_closedetail = new System.Windows.Forms.Label();
            this.lbl_ss = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.dtp_loc = new System.Windows.Forms.DateTimePicker();
            this.btn_lockhoangtg = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.grb_ctsp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrid_cthh = new System.Windows.Forms.DataGridView();
            this.dgrid_bestseller = new System.Windows.Forms.DataGridView();
            this.grb_hide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ss)).BeginInit();
            this.grb_ctsp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cthh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_bestseller)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_hide
            // 
            this.grb_hide.Controls.Add(this.dgrid_ss);
            this.grb_hide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_hide.Location = new System.Drawing.Point(1, 3);
            this.grb_hide.Name = "grb_hide";
            this.grb_hide.Size = new System.Drawing.Size(1031, 210);
            this.grb_hide.TabIndex = 13;
            this.grb_hide.TabStop = false;
            this.grb_hide.Text = "So sánh với tháng trước";
            // 
            // dgrid_ss
            // 
            this.dgrid_ss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_ss.Location = new System.Drawing.Point(3, 23);
            this.dgrid_ss.Name = "dgrid_ss";
            this.dgrid_ss.RowHeadersWidth = 51;
            this.dgrid_ss.RowTemplate.Height = 29;
            this.dgrid_ss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ss.Size = new System.Drawing.Size(1025, 184);
            this.dgrid_ss.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lọc theo mốc thời gian :";
            // 
            // txt_lbllockhoang
            // 
            this.txt_lbllockhoang.AutoSize = true;
            this.txt_lbllockhoang.Location = new System.Drawing.Point(13, 275);
            this.txt_lbllockhoang.Name = "txt_lbllockhoang";
            this.txt_lbllockhoang.Size = new System.Drawing.Size(189, 20);
            this.txt_lbllockhoang.TabIndex = 15;
            this.txt_lbllockhoang.Text = "Lọc theo khoảng thời gian :";
            // 
            // lab_closedetail
            // 
            this.lab_closedetail.AutoSize = true;
            this.lab_closedetail.Location = new System.Drawing.Point(13, 333);
            this.lab_closedetail.Name = "lab_closedetail";
            this.lab_closedetail.Size = new System.Drawing.Size(134, 20);
            this.lab_closedetail.TabIndex = 16;
            this.lab_closedetail.Text = "Đóng xem chi tiết :";
            // 
            // lbl_ss
            // 
            this.lbl_ss.AutoSize = true;
            this.lbl_ss.Location = new System.Drawing.Point(10, 391);
            this.lbl_ss.Name = "lbl_ss";
            this.lbl_ss.Size = new System.Drawing.Size(172, 20);
            this.lbl_ss.TabIndex = 17;
            this.lbl_ss.Text = "So sánh với tháng trước :";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(512, 275);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(133, 20);
            this.lbl_start.TabIndex = 18;
            this.lbl_start.Text = "Thời gian bắt đầu :";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(512, 333);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(134, 20);
            this.lbl_end.TabIndex = 19;
            this.lbl_end.Text = "Thời gian kết thúc :";
            // 
            // dtp_loc
            // 
            this.dtp_loc.Location = new System.Drawing.Point(208, 227);
            this.dtp_loc.Name = "dtp_loc";
            this.dtp_loc.Size = new System.Drawing.Size(241, 27);
            this.dtp_loc.TabIndex = 20;
            this.dtp_loc.ValueChanged += new System.EventHandler(this.dtp_loc_ValueChanged);
            // 
            // btn_lockhoangtg
            // 
            this.btn_lockhoangtg.Location = new System.Drawing.Point(208, 260);
            this.btn_lockhoangtg.Name = "btn_lockhoangtg";
            this.btn_lockhoangtg.Size = new System.Drawing.Size(241, 51);
            this.btn_lockhoangtg.TabIndex = 21;
            this.btn_lockhoangtg.Text = "Lọc theo khoảng thời gian và xem chi tiết";
            this.btn_lockhoangtg.UseVisualStyleBackColor = true;
            this.btn_lockhoangtg.Click += new System.EventHandler(this.btn_lockhoangtg_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(208, 317);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(241, 52);
            this.btn_reload.TabIndex = 22;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "So sánh với tháng trước";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(681, 275);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(241, 27);
            this.dtp_start.TabIndex = 24;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(681, 326);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(241, 27);
            this.dtp_end.TabIndex = 25;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // grb_ctsp
            // 
            this.grb_ctsp.Controls.Add(this.groupBox1);
            this.grb_ctsp.Controls.Add(this.dgrid_bestseller);
            this.grb_ctsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_ctsp.Location = new System.Drawing.Point(4, 433);
            this.grb_ctsp.Name = "grb_ctsp";
            this.grb_ctsp.Size = new System.Drawing.Size(1031, 230);
            this.grb_ctsp.TabIndex = 14;
            this.grb_ctsp.TabStop = false;
            this.grb_ctsp.Text = "Thống kê sản phẩm bán chạy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_cthh);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 230);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê chi tiết sản phẩm bán chạy";
            // 
            // dgrid_cthh
            // 
            this.dgrid_cthh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_cthh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_cthh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_cthh.Location = new System.Drawing.Point(3, 23);
            this.dgrid_cthh.Name = "dgrid_cthh";
            this.dgrid_cthh.RowHeadersWidth = 51;
            this.dgrid_cthh.RowTemplate.Height = 29;
            this.dgrid_cthh.Size = new System.Drawing.Size(1025, 204);
            this.dgrid_cthh.TabIndex = 0;
            // 
            // dgrid_bestseller
            // 
            this.dgrid_bestseller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_bestseller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_bestseller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_bestseller.Location = new System.Drawing.Point(3, 23);
            this.dgrid_bestseller.Name = "dgrid_bestseller";
            this.dgrid_bestseller.RowHeadersWidth = 51;
            this.dgrid_bestseller.RowTemplate.Height = 29;
            this.dgrid_bestseller.Size = new System.Drawing.Size(1025, 204);
            this.dgrid_bestseller.TabIndex = 0;
            // 
            // FormBestSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 663);
            this.Controls.Add(this.grb_ctsp);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_lockhoangtg);
            this.Controls.Add(this.dtp_loc);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_ss);
            this.Controls.Add(this.lab_closedetail);
            this.Controls.Add(this.txt_lbllockhoang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_hide);
            this.Name = "FormBestSeller";
            this.Text = "FormBestSeller";
            this.grb_hide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ss)).EndInit();
            this.grb_ctsp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cthh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_bestseller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grb_hide;
        private DataGridView dgrid_ss;
        private Label label1;
        private Label txt_lbllockhoang;
        private Label lab_closedetail;
        private Label lbl_ss;
        private Label lbl_start;
        private Label lbl_end;
        private DateTimePicker dtp_loc;
        private Button btn_lockhoangtg;
        private Button btn_reload;
        private Button button1;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private GroupBox grb_ctsp;
        private DataGridView dgrid_bestseller;
        private GroupBox groupBox1;
        private DataGridView dgrid_cthh;
    }
}