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
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần Mềm Quản Lý Giáo Viên Và Học Sinh";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageChinh);
            this.tabControl1.Controls.Add(this.tabPageTroGiup);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 105);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageChinh
            // 
            this.tabPageChinh.Controls.Add(this.groupBox2);
            this.tabPageChinh.Controls.Add(this.groupBox1);
            this.tabPageChinh.Location = new System.Drawing.Point(4, 29);
            this.tabPageChinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageChinh.Name = "tabPageChinh";
            this.tabPageChinh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageChinh.Size = new System.Drawing.Size(1002, 476);
            this.tabPageChinh.TabIndex = 0;
            this.tabPageChinh.Text = "Chức Năng";
            this.tabPageChinh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(8, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(985, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm người bất kì";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(8, 32);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(970, 118);
            this.buttonTimKiem.TabIndex = 4;
            this.buttonTimKiem.Text = "Finding nemo";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLich);
            this.groupBox1.Controls.Add(this.buttonHocSinh);
            this.groupBox1.Controls.Add(this.buttonLop);
            this.groupBox1.Controls.Add(this.buttonGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(985, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách quản lý";
            // 
            // buttonLich
            // 
            this.buttonLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLich.Location = new System.Drawing.Point(8, 164);
            this.buttonLich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLich.Name = "buttonLich";
            this.buttonLich.Size = new System.Drawing.Size(480, 118);
            this.buttonLich.TabIndex = 2;
            this.buttonLich.Text = "Lịch Giảng Dạy";
            this.buttonLich.UseVisualStyleBackColor = true;
            this.buttonLich.Click += new System.EventHandler(this.buttonLich_Click);
            // 
            // buttonHocSinh
            // 
            this.buttonHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHocSinh.Location = new System.Drawing.Point(500, 32);
            this.buttonHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHocSinh.Name = "buttonHocSinh";
            this.buttonHocSinh.Size = new System.Drawing.Size(480, 118);
            this.buttonHocSinh.TabIndex = 1;
            this.buttonHocSinh.Text = "Học Sinh";
            this.buttonHocSinh.UseVisualStyleBackColor = true;
            this.buttonHocSinh.Click += new System.EventHandler(this.buttonHocSinh_Click);
            // 
            // buttonLop
            // 
            this.buttonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLop.Location = new System.Drawing.Point(500, 164);
            this.buttonLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLop.Name = "buttonLop";
            this.buttonLop.Size = new System.Drawing.Size(478, 118);
            this.buttonLop.TabIndex = 3;
            this.buttonLop.Text = "Lớp";
            this.buttonLop.UseVisualStyleBackColor = true;
            this.buttonLop.Click += new System.EventHandler(this.buttonLop_Click);
            // 
            // buttonGiaoVien
            // 
            this.buttonGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiaoVien.Location = new System.Drawing.Point(8, 32);
            this.buttonGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGiaoVien.Name = "buttonGiaoVien";
            this.buttonGiaoVien.Size = new System.Drawing.Size(480, 118);
            this.buttonGiaoVien.TabIndex = 0;
            this.buttonGiaoVien.Text = "Giáo Viên";
            this.buttonGiaoVien.UseVisualStyleBackColor = true;
            this.buttonGiaoVien.Click += new System.EventHandler(this.buttonGiaoVien_Click);
            // 
            // tabPageTroGiup
            // 
            this.tabPageTroGiup.Location = new System.Drawing.Point(4, 29);
            this.tabPageTroGiup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTroGiup.Name = "tabPageTroGiup";
            this.tabPageTroGiup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTroGiup.Size = new System.Drawing.Size(1002, 476);
            this.tabPageTroGiup.TabIndex = 1;
            this.tabPageTroGiup.Text = "Trợ Giúp";
            this.tabPageTroGiup.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> parent of 08f290b... thêm form
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1040, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
>>>>>>> parent of 08f290b... thêm form
            this.Name = "FormChinh";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

