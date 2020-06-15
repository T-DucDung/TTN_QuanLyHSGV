namespace TTN_QL_HSGV.GUI.Lop
{
    partial class KhoaHoc
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
            this.buttonSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.textBoxTongSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDS_KH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaKhoa = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(360, 78);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(63, 27);
            this.buttonSua.TabIndex = 65;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Mã Khóa Học :";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.AutoSize = true;
            this.buttonQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(154, 374);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(89, 27);
            this.buttonQuayLai.TabIndex = 56;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // textBoxTongSo
            // 
            this.textBoxTongSo.Enabled = false;
            this.textBoxTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongSo.Location = new System.Drawing.Point(322, 345);
            this.textBoxTongSo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTongSo.Name = "textBoxTongSo";
            this.textBoxTongSo.Size = new System.Drawing.Size(101, 23);
            this.textBoxTongSo.TabIndex = 53;
            this.textBoxTongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tổng Số  :";
            // 
            // dataGridViewDS_KH
            // 
            this.dataGridViewDS_KH.AllowUserToAddRows = false;
            this.dataGridViewDS_KH.AllowUserToDeleteRows = false;
            this.dataGridViewDS_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDS_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS_KH.Location = new System.Drawing.Point(9, 136);
            this.dataGridViewDS_KH.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDS_KH.Name = "dataGridViewDS_KH";
            this.dataGridViewDS_KH.ReadOnly = true;
            this.dataGridViewDS_KH.RowHeadersWidth = 51;
            this.dataGridViewDS_KH.RowTemplate.Height = 24;
            this.dataGridViewDS_KH.Size = new System.Drawing.Size(416, 200);
            this.dataGridViewDS_KH.TabIndex = 51;
            this.dataGridViewDS_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDS_KH_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Danh Sách Khóa Học";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaKhoa.Location = new System.Drawing.Point(115, 51);
            this.textBoxMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(211, 23);
            this.textBoxMaKhoa.TabIndex = 66;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKH.Location = new System.Drawing.Point(115, 84);
            this.textBoxTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(211, 23);
            this.textBoxTenKH.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tên Khóa Học :";
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(360, 49);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(63, 27);
            this.buttonThem.TabIndex = 70;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(360, 105);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(63, 27);
            this.buttonXoa.TabIndex = 71;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // KhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 405);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaKhoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.textBoxTongSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDS_KH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoaHoc";
            this.Load += new System.EventHandler(this.KhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.TextBox textBoxTongSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDS_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaKhoa;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
    }
}