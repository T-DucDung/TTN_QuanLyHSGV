namespace TTN_QL_HSGV.GUI.Lop
{
    partial class DanhSachLop
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
            this.comboBoxKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewDS_Lop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxtenGVCN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoc
            // 
            this.buttonLoc.BackColor = System.Drawing.Color.SeaShell;
            this.buttonLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonLoc.Location = new System.Drawing.Point(572, 58);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(44, 24);
            this.buttonLoc.TabIndex = 65;
            this.buttonLoc.Text = "Lọc";
            this.buttonLoc.UseVisualStyleBackColor = false;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // comboBoxKhoaHoc
            // 
            this.comboBoxKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxKhoaHoc.FormattingEnabled = true;
            this.comboBoxKhoaHoc.Location = new System.Drawing.Point(364, 59);
            this.comboBoxKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKhoaHoc.Name = "comboBoxKhoaHoc";
            this.comboBoxKhoaHoc.Size = new System.Drawing.Size(197, 24);
            this.comboBoxKhoaHoc.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(289, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Khóa Học :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tên GVCN :";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.BackColor = System.Drawing.Color.SeaShell;
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonQuayLai.Location = new System.Drawing.Point(393, 375);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(89, 27);
            this.buttonQuayLai.TabIndex = 56;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.AutoSize = true;
            this.buttonChiTiet.BackColor = System.Drawing.Color.SeaShell;
            this.buttonChiTiet.Enabled = false;
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonChiTiet.Location = new System.Drawing.Point(283, 375);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(86, 27);
            this.buttonChiTiet.TabIndex = 55;
            this.buttonChiTiet.Text = "Chi Tiết ";
            this.buttonChiTiet.UseVisualStyleBackColor = false;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.BackColor = System.Drawing.Color.SeaShell;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonThem.Location = new System.Drawing.Point(168, 375);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(86, 27);
            this.buttonThem.TabIndex = 54;
            this.buttonThem.Text = "Thêm Lớp";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dataGridViewDS_Lop
            // 
            this.dataGridViewDS_Lop.AllowUserToAddRows = false;
            this.dataGridViewDS_Lop.AllowUserToDeleteRows = false;
            this.dataGridViewDS_Lop.AllowUserToResizeRows = false;
            this.dataGridViewDS_Lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDS_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_Lop.Location = new System.Drawing.Point(10, 87);
            this.dataGridViewDS_Lop.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDS_Lop.Name = "dataGridViewDS_Lop";
            this.dataGridViewDS_Lop.ReadOnly = true;
            this.dataGridViewDS_Lop.RowHeadersVisible = false;
            this.dataGridViewDS_Lop.RowTemplate.Height = 24;
            this.dataGridViewDS_Lop.Size = new System.Drawing.Size(606, 284);
            this.dataGridViewDS_Lop.TabIndex = 51;
            this.dataGridViewDS_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDS_Lop_CellClick);
            this.dataGridViewDS_Lop.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDS_Lop_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Danh Sách Lớp\r\n";
            // 
            // textBoxtenGVCN
            // 
            this.textBoxtenGVCN.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxtenGVCN.Location = new System.Drawing.Point(87, 58);
            this.textBoxtenGVCN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenGVCN.Name = "textBoxtenGVCN";
            this.textBoxtenGVCN.ReadOnly = true;
            this.textBoxtenGVCN.Size = new System.Drawing.Size(189, 22);
            this.textBoxtenGVCN.TabIndex = 66;
            // 
            // DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.textBoxtenGVCN);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.comboBoxKhoaHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.buttonChiTiet);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridViewDS_Lop);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.DanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.ComboBox comboBoxKhoaHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewDS_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxtenGVCN;
    }
}