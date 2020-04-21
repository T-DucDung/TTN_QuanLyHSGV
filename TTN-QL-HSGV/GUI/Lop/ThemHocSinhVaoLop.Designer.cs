namespace TTN_QL_HSGV.GUI.Lop
{
    partial class ThemHocSinhVaoLop
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
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewDS_HS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(763, 71);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(59, 30);
            this.buttonLoc.TabIndex = 65;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(507, 70);
            this.comboBoxLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(201, 28);
            this.comboBoxLop.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Lớp :";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "None",
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(176, 70);
            this.comboBoxGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(188, 28);
            this.comboBoxGioiTinh.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Giới Tính :";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(591, 463);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(119, 33);
            this.buttonQuayLai.TabIndex = 56;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.AutoSize = true;
            this.buttonChiTiet.Enabled = false;
            this.buttonChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(441, 463);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(115, 33);
            this.buttonChiTiet.TabIndex = 55;
            this.buttonChiTiet.Text = "Chi Tiết ";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(109, 463);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(188, 33);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm Mới Học Sinh";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewDS_HS
            // 
            this.dataGridViewDS_HS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDS_HS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_HS.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewDS_HS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDS_HS.Name = "dataGridViewDS_HS";
            this.dataGridViewDS_HS.RowTemplate.Height = 24;
            this.dataGridViewDS_HS.Size = new System.Drawing.Size(808, 351);
            this.dataGridViewDS_HS.TabIndex = 51;
            this.dataGridViewDS_HS.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDS_HS_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 50;
            this.label1.Text = "Chọn Học Sinh Vào Lớp";
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(315, 463);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(109, 33);
            this.buttonLuu.TabIndex = 66;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // ThemHocSinhVaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.comboBoxLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonChiTiet);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewDS_HS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemHocSinhVaoLop";
            this.Text = "ThemHocSinhVaoLop";
            this.Load += new System.EventHandler(this.ThemHocSinhVaoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_HS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewDS_HS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLuu;
    }
}