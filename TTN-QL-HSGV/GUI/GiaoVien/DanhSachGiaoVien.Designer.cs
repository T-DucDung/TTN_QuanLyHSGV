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
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Danh Sách Giáo Viên\r\n";
            // 
            // dataGridViewDS_GV
            // 
            this.dataGridViewDS_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_GV.Location = new System.Drawing.Point(12, 106);
            this.dataGridViewDS_GV.Name = "dataGridViewDS_GV";
            this.dataGridViewDS_GV.RowTemplate.Height = 24;
            this.dataGridViewDS_GV.Size = new System.Drawing.Size(808, 320);
            this.dataGridViewDS_GV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tổng Số  :";
            // 
            // textBoxTongSo
            // 
            this.textBoxTongSo.Enabled = false;
            this.textBoxTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongSo.Location = new System.Drawing.Point(687, 429);
            this.textBoxTongSo.Name = "textBoxTongSo";
            this.textBoxTongSo.Size = new System.Drawing.Size(133, 27);
            this.textBoxTongSo.TabIndex = 28;
            this.textBoxTongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(195, 461);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(172, 30);
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
            this.buttonChiTiet.Location = new System.Drawing.Point(388, 461);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(115, 30);
            this.buttonChiTiet.TabIndex = 30;
            this.buttonChiTiet.Text = "Chi Tiết ";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(522, 461);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(119, 30);
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
            "Nữ",
            "Nam",
            "Khác",
            "None"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(104, 73);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(98, 28);
            this.comboBoxGioiTinh.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giới Tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chức Vụ :";
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(309, 71);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(143, 28);
            this.comboBoxChucVu.TabIndex = 37;
            // 
            // comboBoxMon
            // 
            this.comboBoxMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMon.FormattingEnabled = true;
            this.comboBoxMon.Location = new System.Drawing.Point(573, 72);
            this.comboBoxMon.Name = "comboBoxMon";
            this.comboBoxMon.Size = new System.Drawing.Size(147, 28);
            this.comboBoxMon.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dạy Môn :";
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(761, 70);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(59, 30);
            this.buttonLoc.TabIndex = 40;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            // 
            // DanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
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
            this.MaximizeBox = false;
            this.Name = "DanhSachGiaoVien";
            this.Text = "DanhSachGiaoVien";
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