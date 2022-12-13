namespace C_GUI.Views
{
    partial class FormThongKe
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
            this._dgrv_doanhthu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ngay = new System.Windows.Forms.ComboBox();
            this.cmb_loc = new System.Windows.Forms.ComboBox();
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgrv_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._dgrv_doanhthu);
            this.groupBox1.Location = new System.Drawing.Point(6, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Doanh Thu Nhân Viên";
            // 
            // _dgrv_doanhthu
            // 
            this._dgrv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgrv_doanhthu.Location = new System.Drawing.Point(5, 30);
            this._dgrv_doanhthu.Name = "_dgrv_doanhthu";
            this._dgrv_doanhthu.RowHeadersWidth = 51;
            this._dgrv_doanhthu.RowTemplate.Height = 29;
            this._dgrv_doanhthu.Size = new System.Drawing.Size(1091, 238);
            this._dgrv_doanhthu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Theo Năm";
            // 
            // cmb_ngay
            // 
            this.cmb_ngay.FormattingEnabled = true;
            this.cmb_ngay.Location = new System.Drawing.Point(108, 88);
            this.cmb_ngay.Name = "cmb_ngay";
            this.cmb_ngay.Size = new System.Drawing.Size(151, 28);
            this.cmb_ngay.TabIndex = 7;
            this.cmb_ngay.SelectedIndexChanged += new System.EventHandler(this.cbo_ngay_SelectedValueChanged);
            this.cmb_ngay.RightToLeftChanged += new System.EventHandler(this.cbo_ngay_SelectedValueChanged);
            // 
            // cmb_loc
            // 
            this.cmb_loc.FormattingEnabled = true;
            this.cmb_loc.Location = new System.Drawing.Point(510, 88);
            this.cmb_loc.Name = "cmb_loc";
            this.cmb_loc.Size = new System.Drawing.Size(151, 28);
            this.cmb_loc.TabIndex = 8;
            this.cmb_loc.SelectedIndexChanged += new System.EventHandler(this.cbo_loc_SelectedIndexChanged);
            this.cmb_loc.SelectedValueChanged += new System.EventHandler(this.cbo_loc_SelectedIndexChanged);
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(861, 88);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(151, 28);
            this.cmb_nam.TabIndex = 9;
            this.cmb_nam.SelectedIndexChanged += new System.EventHandler(this.cmb_nam_OnSelectedIndexChanged);
            this.cmb_nam.RightToLeftChanged += new System.EventHandler(this.cmb_nam_OnSelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_nam);
            this.Controls.Add(this.cmb_loc);
            this.Controls.Add(this.cmb_ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgrv_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView _dgrv_doanhthu;
        private Label label3;
        private ComboBox cmb_ngay;
        private ComboBox cmb_loc;
        private ComboBox cmb_nam;
        private Button button1;
    }
}