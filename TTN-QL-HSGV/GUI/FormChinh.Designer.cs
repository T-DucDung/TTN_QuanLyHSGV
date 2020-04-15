namespace TTN_QL_HSGV
{
    partial class FormChinh
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageChinh = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLich = new System.Windows.Forms.Button();
            this.buttonHocSinh = new System.Windows.Forms.Button();
            this.buttonLop = new System.Windows.Forms.Button();
            this.buttonGiaoVien = new System.Windows.Forms.Button();
            this.tabPageTroGiup = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageChinh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần Mềm Quản Lý Giáo Viên Và Học Sinh";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageChinh);
            this.tabControl1.Controls.Add(this.tabPageTroGiup);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 331);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageChinh
            // 
            this.tabPageChinh.Controls.Add(this.groupBox2);
            this.tabPageChinh.Controls.Add(this.groupBox1);
            this.tabPageChinh.Location = new System.Drawing.Point(4, 26);
            this.tabPageChinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChinh.Name = "tabPageChinh";
            this.tabPageChinh.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChinh.Size = new System.Drawing.Size(598, 301);
            this.tabPageChinh.TabIndex = 0;
            this.tabPageChinh.Text = "Chức Năng";
            this.tabPageChinh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(4, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(591, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm người bất kì";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(4, 21);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(582, 76);
            this.buttonTimKiem.TabIndex = 4;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLich);
            this.groupBox1.Controls.Add(this.buttonHocSinh);
            this.groupBox1.Controls.Add(this.buttonLop);
            this.groupBox1.Controls.Add(this.buttonGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(591, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách quản lý";
            // 
            // buttonLich
            // 
            this.buttonLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLich.Location = new System.Drawing.Point(4, 106);
            this.buttonLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLich.Name = "buttonLich";
            this.buttonLich.Size = new System.Drawing.Size(288, 76);
            this.buttonLich.TabIndex = 2;
            this.buttonLich.Text = "Lịch Giảng Dạy";
            this.buttonLich.UseVisualStyleBackColor = true;
            this.buttonLich.Click += new System.EventHandler(this.buttonLich_Click);
            // 
            // buttonHocSinh
            // 
            this.buttonHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHocSinh.Location = new System.Drawing.Point(300, 21);
            this.buttonHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHocSinh.Name = "buttonHocSinh";
            this.buttonHocSinh.Size = new System.Drawing.Size(288, 76);
            this.buttonHocSinh.TabIndex = 1;
            this.buttonHocSinh.Text = "Học Sinh";
            this.buttonHocSinh.UseVisualStyleBackColor = true;
            this.buttonHocSinh.Click += new System.EventHandler(this.buttonHocSinh_Click);
            // 
            // buttonLop
            // 
            this.buttonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLop.Location = new System.Drawing.Point(300, 106);
            this.buttonLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLop.Name = "buttonLop";
            this.buttonLop.Size = new System.Drawing.Size(286, 76);
            this.buttonLop.TabIndex = 3;
            this.buttonLop.Text = "Lớp";
            this.buttonLop.UseVisualStyleBackColor = true;
            this.buttonLop.Click += new System.EventHandler(this.buttonLop_Click);
            // 
            // buttonGiaoVien
            // 
            this.buttonGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiaoVien.Location = new System.Drawing.Point(4, 21);
            this.buttonGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGiaoVien.Name = "buttonGiaoVien";
            this.buttonGiaoVien.Size = new System.Drawing.Size(288, 76);
            this.buttonGiaoVien.TabIndex = 0;
            this.buttonGiaoVien.Text = "Giáo Viên";
            this.buttonGiaoVien.UseVisualStyleBackColor = true;
            this.buttonGiaoVien.Click += new System.EventHandler(this.buttonGiaoVien_Click);
            // 
            // tabPageTroGiup
            // 
            this.tabPageTroGiup.Location = new System.Drawing.Point(4, 26);
            this.tabPageTroGiup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTroGiup.Name = "tabPageTroGiup";
            this.tabPageTroGiup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTroGiup.Size = new System.Drawing.Size(598, 301);
            this.tabPageTroGiup.TabIndex = 1;
            this.tabPageTroGiup.Text = "Trợ Giúp";
            this.tabPageTroGiup.UseVisualStyleBackColor = true;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageChinh.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageChinh;
        private System.Windows.Forms.TabPage tabPageTroGiup;
        private System.Windows.Forms.Button buttonLop;
        private System.Windows.Forms.Button buttonLich;
        private System.Windows.Forms.Button buttonHocSinh;
        private System.Windows.Forms.Button buttonGiaoVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}

