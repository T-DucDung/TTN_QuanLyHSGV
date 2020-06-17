namespace TTN_QL_HSGV.GUI.TimKiem
{
    partial class ChiTiet
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
            this.buttonLoc = new System.Windows.Forms.Button();
            this.comboBoxGiaoVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBuoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxThu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.textBoxTongSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDS_HS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoc
            // 
            this.buttonLoc.AutoSize = true;
            this.buttonLoc.BackColor = System.Drawing.Color.SeaShell;
            this.buttonLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonLoc.Location = new System.Drawing.Point(736, 73);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(81, 58);
            this.buttonLoc.TabIndex = 81;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = false;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // comboBoxGiaoVien
            // 
            this.comboBoxGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGiaoVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxGiaoVien.FormattingEnabled = true;
            this.comboBoxGiaoVien.Items.AddRange(new object[] {
            "None"});
            this.comboBoxGiaoVien.Location = new System.Drawing.Point(447, 101);
            this.comboBoxGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGiaoVien.Name = "comboBoxGiaoVien";
            this.comboBoxGiaoVien.Size = new System.Drawing.Size(211, 27);
            this.comboBoxGiaoVien.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(331, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Giáo Viên :";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Items.AddRange(new object[] {
            "None"});
            this.comboBoxLop.Location = new System.Drawing.Point(71, 101);
            this.comboBoxLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(231, 27);
            this.comboBoxLop.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Lớp :";
            // 
            // comboBoxBuoi
            // 
            this.comboBoxBuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxBuoi.FormattingEnabled = true;
            this.comboBoxBuoi.Items.AddRange(new object[] {
            "Cả sáng, chiều",
            "Sáng",
            "Chiều"});
            this.comboBoxBuoi.Location = new System.Drawing.Point(447, 69);
            this.comboBoxBuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBuoi.Name = "comboBoxBuoi";
            this.comboBoxBuoi.Size = new System.Drawing.Size(211, 27);
            this.comboBoxBuoi.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(331, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Buổi          :";
            // 
            // comboBoxThu
            // 
            this.comboBoxThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxThu.FormattingEnabled = true;
            this.comboBoxThu.Items.AddRange(new object[] {
            "Cả Tuần",
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.comboBoxThu.Location = new System.Drawing.Point(71, 69);
            this.comboBoxThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxThu.Name = "comboBoxThu";
            this.comboBoxThu.Size = new System.Drawing.Size(231, 27);
            this.comboBoxThu.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Thứ :";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.BackColor = System.Drawing.Color.SeaShell;
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonQuayLai.Location = new System.Drawing.Point(464, 462);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(119, 33);
            this.buttonQuayLai.TabIndex = 72;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.AutoSize = true;
            this.buttonChiTiet.BackColor = System.Drawing.Color.SeaShell;
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonChiTiet.Location = new System.Drawing.Point(269, 462);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(115, 33);
            this.buttonChiTiet.TabIndex = 71;
            this.buttonChiTiet.Text = "Chi Tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = false;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // textBoxTongSo
            // 
            this.textBoxTongSo.Enabled = false;
            this.textBoxTongSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxTongSo.Location = new System.Drawing.Point(689, 430);
            this.textBoxTongSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTongSo.Name = "textBoxTongSo";
            this.textBoxTongSo.ReadOnly = true;
            this.textBoxTongSo.Size = new System.Drawing.Size(133, 26);
            this.textBoxTongSo.TabIndex = 69;
            this.textBoxTongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(597, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tổng Số  :";
            // 
            // dataGridViewDS_HS
            // 
            this.dataGridViewDS_HS.AllowUserToAddRows = false;
            this.dataGridViewDS_HS.AllowUserToDeleteRows = false;
            this.dataGridViewDS_HS.AllowUserToResizeRows = false;
            this.dataGridViewDS_HS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDS_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_HS.Location = new System.Drawing.Point(13, 142);
            this.dataGridViewDS_HS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDS_HS.Name = "dataGridViewDS_HS";
            this.dataGridViewDS_HS.ReadOnly = true;
            this.dataGridViewDS_HS.RowHeadersVisible = false;
            this.dataGridViewDS_HS.RowHeadersWidth = 51;
            this.dataGridViewDS_HS.RowTemplate.Height = 24;
            this.dataGridViewDS_HS.Size = new System.Drawing.Size(808, 287);
            this.dataGridViewDS_HS.TabIndex = 67;
            this.dataGridViewDS_HS.DataSourceChanged += new System.EventHandler(this.dataGridViewDS_HS_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(147, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 34);
            this.label1.TabIndex = 66;
            this.label1.Text = "Chi Tiết Lịch Của Người Cần Tìm Kiếm";
            // 
            // ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.comboBoxGiaoVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonChiTiet);
            this.Controls.Add(this.textBoxTongSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDS_HS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết";
            this.Load += new System.EventHandler(this.ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxGiaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.TextBox textBoxTongSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDS_HS;
        private System.Windows.Forms.Label label1;
    }
}