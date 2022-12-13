namespace C_GUI.Views
{
    partial class FormImport
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
            this.btn_link = new C_GUI.RJControls.RJButton();
            this.rjButton2 = new C_GUI.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._dgrvThongTinSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgrvThongTinSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_link
            // 
            this.btn_link.BackColor = System.Drawing.Color.Turquoise;
            this.btn_link.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_link.BorderColor = System.Drawing.Color.Black;
            this.btn_link.BorderRadius = 15;
            this.btn_link.BorderSize = 2;
            this.btn_link.FlatAppearance.BorderSize = 0;
            this.btn_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link.ForeColor = System.Drawing.Color.Black;
            this.btn_link.Location = new System.Drawing.Point(22, 22);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(188, 39);
            this.btn_link.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_link.TabIndex = 0;
            this.btn_link.Text = "Link";
            this.btn_link.TextColor = System.Drawing.Color.Black;
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Turquoise;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Turquoise;
            this.rjButton2.BorderColor = System.Drawing.Color.Black;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(249, 22);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(188, 39);
            this.rjButton2.SizeImage = new System.Drawing.Size(20, 20);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.Text = "Save";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._dgrvThongTinSanPham);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // _dgrvThongTinSanPham
            // 
            this._dgrvThongTinSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgrvThongTinSanPham.Location = new System.Drawing.Point(17, 42);
            this._dgrvThongTinSanPham.Name = "_dgrvThongTinSanPham";
            this._dgrvThongTinSanPham.RowHeadersWidth = 51;
            this._dgrvThongTinSanPham.RowTemplate.Height = 29;
            this._dgrvThongTinSanPham.Size = new System.Drawing.Size(951, 279);
            this._dgrvThongTinSanPham.TabIndex = 0;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btn_link);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormImport_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgrvThongTinSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.RJButton btn_link;
        private RJControls.RJButton rjButton2;
        private GroupBox groupBox1;
        private DataGridView _dgrvThongTinSanPham;
    }
}