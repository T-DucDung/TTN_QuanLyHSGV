﻿namespace TTN_QL_HSGV.GUI.Lop
{
    partial class ThongTinLop
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
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonChiTietHS = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewDS_HS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGVCN = new System.Windows.Forms.ComboBox();
            this.buttonChiTietGV = new System.Windows.Forms.Button();
            this.comboBoxKhoaHoc = new System.Windows.Forms.ComboBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.BackColor = System.Drawing.Color.SeaShell;
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonQuayLai.Location = new System.Drawing.Point(441, 375);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(89, 27);
            this.buttonQuayLai.TabIndex = 56;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonChiTietHS
            // 
            this.buttonChiTietHS.AutoSize = true;
            this.buttonChiTietHS.BackColor = System.Drawing.Color.SeaShell;
            this.buttonChiTietHS.Enabled = false;
            this.buttonChiTietHS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTietHS.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonChiTietHS.Location = new System.Drawing.Point(260, 376);
            this.buttonChiTietHS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChiTietHS.Name = "buttonChiTietHS";
            this.buttonChiTietHS.Size = new System.Drawing.Size(128, 27);
            this.buttonChiTietHS.TabIndex = 55;
            this.buttonChiTietHS.Text = "Chi Tiết Học Sinh";
            this.buttonChiTietHS.UseVisualStyleBackColor = false;
            this.buttonChiTietHS.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.BackColor = System.Drawing.Color.SeaShell;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonThem.Location = new System.Drawing.Point(74, 375);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(129, 27);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm Học Sinh";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewDS_HS
            // 
            this.dataGridViewDS_HS.AllowUserToAddRows = false;
            this.dataGridViewDS_HS.AllowUserToDeleteRows = false;
            this.dataGridViewDS_HS.AllowUserToResizeRows = false;
            this.dataGridViewDS_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_HS.Location = new System.Drawing.Point(10, 114);
            this.dataGridViewDS_HS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDS_HS.Name = "dataGridViewDS_HS";
            this.dataGridViewDS_HS.ReadOnly = true;
            this.dataGridViewDS_HS.RowHeadersVisible = false;
            this.dataGridViewDS_HS.RowTemplate.Height = 24;
            this.dataGridViewDS_HS.Size = new System.Drawing.Size(606, 257);
            this.dataGridViewDS_HS.TabIndex = 51;
            this.dataGridViewDS_HS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDS_HS_CellClick);
            this.dataGridViewDS_HS.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDS_HS_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Danh Sách Học Sinh\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên Lớp    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(171, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Khóa Học :";
            // 
            // textBoxLop
            // 
            this.textBoxLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxLop.Location = new System.Drawing.Point(88, 86);
            this.textBoxLop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(79, 22);
            this.textBoxLop.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tên GVCN :";
            // 
            // comboBoxGVCN
            // 
            this.comboBoxGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGVCN.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxGVCN.FormattingEnabled = true;
            this.comboBoxGVCN.Location = new System.Drawing.Point(88, 53);
            this.comboBoxGVCN.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGVCN.Name = "comboBoxGVCN";
            this.comboBoxGVCN.Size = new System.Drawing.Size(383, 24);
            this.comboBoxGVCN.TabIndex = 69;
            // 
            // buttonChiTietGV
            // 
            this.buttonChiTietGV.AutoSize = true;
            this.buttonChiTietGV.BackColor = System.Drawing.Color.SeaShell;
            this.buttonChiTietGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTietGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonChiTietGV.Location = new System.Drawing.Point(475, 51);
            this.buttonChiTietGV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChiTietGV.Name = "buttonChiTietGV";
            this.buttonChiTietGV.Size = new System.Drawing.Size(142, 27);
            this.buttonChiTietGV.TabIndex = 70;
            this.buttonChiTietGV.Text = "Chi Tiết Giáo Viên";
            this.buttonChiTietGV.UseVisualStyleBackColor = false;
            this.buttonChiTietGV.Click += new System.EventHandler(this.buttonChiTietGV_Click);
            // 
            // comboBoxKhoaHoc
            // 
            this.comboBoxKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxKhoaHoc.FormattingEnabled = true;
            this.comboBoxKhoaHoc.Location = new System.Drawing.Point(246, 86);
            this.comboBoxKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKhoaHoc.Name = "comboBoxKhoaHoc";
            this.comboBoxKhoaHoc.Size = new System.Drawing.Size(225, 24);
            this.comboBoxKhoaHoc.TabIndex = 74;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.SeaShell;
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonLuu.Location = new System.Drawing.Point(475, 84);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(142, 27);
            this.buttonLuu.TabIndex = 102;
            this.buttonLuu.Text = "Lưu Lại Thay Đổi";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // ThongTinLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.comboBoxKhoaHoc);
            this.Controls.Add(this.buttonChiTietGV);
            this.Controls.Add(this.comboBoxGVCN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonChiTietHS);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewDS_HS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ThongTinLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lớp";
            this.Load += new System.EventHandler(this.ThongTinLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonChiTietHS;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewDS_HS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGVCN;
        private System.Windows.Forms.Button buttonChiTietGV;
        private System.Windows.Forms.ComboBox comboBoxKhoaHoc;
        private System.Windows.Forms.Button buttonLuu;
    }
}