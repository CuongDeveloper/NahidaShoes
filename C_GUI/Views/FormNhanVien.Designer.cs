namespace C_GUI.Views
{
    partial class FormNhanVien
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
            this._lblThongTinNhanVien = new System.Windows.Forms.Label();
            this.rjButton1 = new C_GUI.RJControls.RJButton();
            this._tbxMoi1 = new C_GUI.RJControls.RJTextBox();
            this._tbxMoi = new C_GUI.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbxCu = new C_GUI.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // _lblThongTinNhanVien
            // 
            this._lblThongTinNhanVien.AutoSize = true;
            this._lblThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblThongTinNhanVien.Location = new System.Drawing.Point(12, 9);
            this._lblThongTinNhanVien.Name = "_lblThongTinNhanVien";
            this._lblThongTinNhanVien.Size = new System.Drawing.Size(148, 21);
            this._lblThongTinNhanVien.TabIndex = 0;
            this._lblThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Turquoise;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(12, 407);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(403, 31);
            this.rjButton1.SizeImage = new System.Drawing.Size(20, 20);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Đổi mật khẩu";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // _tbxMoi1
            // 
            this._tbxMoi1.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMoi1.BorderColor = System.Drawing.Color.Black;
            this._tbxMoi1.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMoi1.BorderRadius = 15;
            this._tbxMoi1.BorderSize = 2;
            this._tbxMoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMoi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMoi1.Location = new System.Drawing.Point(13, 369);
            this._tbxMoi1.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMoi1.MaxLength = 20;
            this._tbxMoi1.Multiline = false;
            this._tbxMoi1.Name = "_tbxMoi1";
            this._tbxMoi1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMoi1.PasswordChar = false;
            this._tbxMoi1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMoi1.PlaceholderText = "";
            this._tbxMoi1.Size = new System.Drawing.Size(402, 31);
            this._tbxMoi1.TabIndex = 2;
            this._tbxMoi1.Texts = "";
            this._tbxMoi1.UnderlinedStyle = false;
            // 
            // _tbxMoi
            // 
            this._tbxMoi.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMoi.BorderColor = System.Drawing.Color.Black;
            this._tbxMoi.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMoi.BorderRadius = 15;
            this._tbxMoi.BorderSize = 2;
            this._tbxMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMoi.Location = new System.Drawing.Point(12, 315);
            this._tbxMoi.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMoi.MaxLength = 20;
            this._tbxMoi.Multiline = false;
            this._tbxMoi.Name = "_tbxMoi";
            this._tbxMoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMoi.PasswordChar = false;
            this._tbxMoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMoi.PlaceholderText = "";
            this._tbxMoi.Size = new System.Drawing.Size(401, 31);
            this._tbxMoi.TabIndex = 3;
            this._tbxMoi.Texts = "";
            this._tbxMoi.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập mật khẩu cũ";
            // 
            // _tbxCu
            // 
            this._tbxCu.BackColor = System.Drawing.SystemColors.Window;
            this._tbxCu.BorderColor = System.Drawing.Color.Black;
            this._tbxCu.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxCu.BorderRadius = 15;
            this._tbxCu.BorderSize = 2;
            this._tbxCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxCu.Location = new System.Drawing.Point(13, 261);
            this._tbxCu.Margin = new System.Windows.Forms.Padding(4);
            this._tbxCu.MaxLength = 20;
            this._tbxCu.Multiline = false;
            this._tbxCu.Name = "_tbxCu";
            this._tbxCu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxCu.PasswordChar = false;
            this._tbxCu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxCu.PlaceholderText = "";
            this._tbxCu.Size = new System.Drawing.Size(401, 31);
            this._tbxCu.TabIndex = 6;
            this._tbxCu.Texts = "";
            this._tbxCu.UnderlinedStyle = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbxCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbxMoi);
            this.Controls.Add(this._tbxMoi1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this._lblThongTinNhanVien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblThongTinNhanVien;
        private RJControls.RJButton rjButton1;
        private RJControls.RJTextBox _tbxMoi1;
        private RJControls.RJTextBox _tbxMoi;
        private Label label1;
        private Label label2;
        private Label label3;
        private RJControls.RJTextBox _tbxCu;
    }
}