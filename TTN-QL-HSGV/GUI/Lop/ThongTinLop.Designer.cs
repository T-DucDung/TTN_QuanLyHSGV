namespace TTN_QL_HSGV.GUI.Lop
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
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(590, 462);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(119, 33);
            this.buttonQuayLai.TabIndex = 56;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonChiTietHS
            // 
            this.buttonChiTietHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTietHS.Location = new System.Drawing.Point(348, 463);
            this.buttonChiTietHS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChiTietHS.Name = "buttonChiTietHS";
            this.buttonChiTietHS.Size = new System.Drawing.Size(171, 30);
            this.buttonChiTietHS.TabIndex = 55;
            this.buttonChiTietHS.Text = "Chi Tiết Học Sinh";
            this.buttonChiTietHS.UseVisualStyleBackColor = true;
            this.buttonChiTietHS.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(100, 462);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(172, 33);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm Học Sinh";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewDS_HS
            // 
            this.dataGridViewDS_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_HS.Location = new System.Drawing.Point(13, 140);
            this.dataGridViewDS_HS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDS_HS.Name = "dataGridViewDS_HS";
            this.dataGridViewDS_HS.RowTemplate.Height = 24;
            this.dataGridViewDS_HS.Size = new System.Drawing.Size(808, 316);
            this.dataGridViewDS_HS.TabIndex = 51;
            this.dataGridViewDS_HS.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDS_HS_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Danh Sách Học Sinh\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tên Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Khóa Học ";
            // 
            // textBoxLop
            // 
            this.textBoxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLop.Location = new System.Drawing.Point(116, 106);
            this.textBoxLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.Size = new System.Drawing.Size(64, 27);
            this.textBoxLop.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tên GVCN";
            // 
            // comboBoxGVCN
            // 
            this.comboBoxGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGVCN.FormattingEnabled = true;
            this.comboBoxGVCN.Location = new System.Drawing.Point(133, 65);
            this.comboBoxGVCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGVCN.Name = "comboBoxGVCN";
            this.comboBoxGVCN.Size = new System.Drawing.Size(493, 28);
            this.comboBoxGVCN.TabIndex = 69;
            // 
            // buttonChiTietGV
            // 
            this.buttonChiTietGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTietGV.Location = new System.Drawing.Point(633, 66);
            this.buttonChiTietGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChiTietGV.Name = "buttonChiTietGV";
            this.buttonChiTietGV.Size = new System.Drawing.Size(189, 30);
            this.buttonChiTietGV.TabIndex = 70;
            this.buttonChiTietGV.Text = "Chi Tiết Giáo Viên";
            this.buttonChiTietGV.UseVisualStyleBackColor = true;
            this.buttonChiTietGV.Click += new System.EventHandler(this.buttonChiTietGV_Click);
            // 
            // comboBoxKhoaHoc
            // 
            this.comboBoxKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKhoaHoc.FormattingEnabled = true;
            this.comboBoxKhoaHoc.Location = new System.Drawing.Point(312, 106);
            this.comboBoxKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKhoaHoc.Name = "comboBoxKhoaHoc";
            this.comboBoxKhoaHoc.Size = new System.Drawing.Size(315, 28);
            this.comboBoxKhoaHoc.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = ":";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(633, 103);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(189, 30);
            this.buttonLuu.TabIndex = 102;
            this.buttonLuu.Text = "Lưu Lại Thay Đổi";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // ThongTinLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinLop";
            this.Text = "ThongTinLop";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonLuu;
    }
}