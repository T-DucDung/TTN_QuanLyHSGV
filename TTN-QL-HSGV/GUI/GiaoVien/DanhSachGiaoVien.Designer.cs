namespace TTN_QL_HSGV.GUI.GiaoVien
{
    partial class DanhSachGiaoVien
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
            this.dataGridViewDS_GV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTongSo = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.comboBoxMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Danh Sách Giáo Viên\r\n";
            // 
            // dataGridViewDS_GV
            // 
            this.dataGridViewDS_GV.AllowUserToAddRows = false;
            this.dataGridViewDS_GV.AllowUserToDeleteRows = false;
            this.dataGridViewDS_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_GV.Location = new System.Drawing.Point(9, 86);
            this.dataGridViewDS_GV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDS_GV.Name = "dataGridViewDS_GV";
            this.dataGridViewDS_GV.ReadOnly = true;
            this.dataGridViewDS_GV.RowTemplate.Height = 24;
            this.dataGridViewDS_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDS_GV.Size = new System.Drawing.Size(606, 260);
            this.dataGridViewDS_GV.TabIndex = 26;
            this.dataGridViewDS_GV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewDS_GV_ColumnHeaderMouseClick);
            this.dataGridViewDS_GV.Click += new System.EventHandler(this.DataGridViewDS_GV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tổng Số  :";
            // 
            // textBoxTongSo
            // 
            this.textBoxTongSo.Enabled = false;
            this.textBoxTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongSo.Location = new System.Drawing.Point(515, 349);
            this.textBoxTongSo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTongSo.Name = "textBoxTongSo";
            this.textBoxTongSo.Size = new System.Drawing.Size(101, 23);
            this.textBoxTongSo.TabIndex = 28;
            this.textBoxTongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(146, 375);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(129, 27);
            this.buttonThem.TabIndex = 29;
            this.buttonThem.Text = "Thêm Giáo Viên";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.AutoSize = true;
            this.buttonChiTiet.Enabled = false;
            this.buttonChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(291, 375);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(86, 27);
            this.buttonChiTiet.TabIndex = 30;
            this.buttonChiTiet.Text = "Chi Tiết ";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(392, 375);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(89, 27);
            this.buttonQuayLai.TabIndex = 31;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "NỮ",
            "NAM",
            "None"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(78, 59);
            this.comboBoxGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(74, 25);
            this.comboBoxGioiTinh.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giới Tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chức Vụ :";
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Items.AddRange(new object[] {
            "None"});
            this.comboBoxChucVu.Location = new System.Drawing.Point(232, 58);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(108, 25);
            this.comboBoxChucVu.TabIndex = 37;
            // 
            // comboBoxMon
            // 
            this.comboBoxMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMon.FormattingEnabled = true;
            this.comboBoxMon.Location = new System.Drawing.Point(430, 58);
            this.comboBoxMon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMon.Name = "comboBoxMon";
            this.comboBoxMon.Size = new System.Drawing.Size(111, 25);
            this.comboBoxMon.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dạy Môn :";
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(571, 57);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(44, 24);
            this.buttonLoc.TabIndex = 40;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.ButtonLoc_Click);
            // 
            // DanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.comboBoxMon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxChucVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonChiTiet);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxTongSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDS_GV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DanhSachGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachGiaoVien";
            this.Load += new System.EventHandler(this.DanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDS_GV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTongSo;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.ComboBox comboBoxMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLoc;
    }
}