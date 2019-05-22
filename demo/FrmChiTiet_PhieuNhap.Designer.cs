namespace demo
{
    partial class FrmChiTiet_PhieuNhap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SOPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLGIAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOHIEUDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSOPN = new System.Windows.Forms.TextBox();
            this.txtMAHH = new System.Windows.Forms.TextBox();
            this.txtSLGIAO = new System.Windows.Forms.TextBox();
            this.txtSLNHAN = new System.Windows.Forms.TextBox();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.txtSOHIEUDH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPN,
            this.TENHH,
            this.SLGIAO,
            this.SLNHAN,
            this.DONGIA,
            this.SOHIEUDH});
            this.dataGridView1.Location = new System.Drawing.Point(27, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SOPN
            // 
            this.SOPN.DataPropertyName = "SOPN";
            this.SOPN.HeaderText = "Số phiếu";
            this.SOPN.Name = "SOPN";
            this.SOPN.Width = 130;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên hàng hóa";
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 160;
            // 
            // SLGIAO
            // 
            this.SLGIAO.DataPropertyName = "SLGIAO";
            this.SLGIAO.HeaderText = "Số lượng chứng tờ";
            this.SLGIAO.Name = "SLGIAO";
            this.SLGIAO.Width = 150;
            // 
            // SLNHAN
            // 
            this.SLNHAN.DataPropertyName = "SLNHAN";
            this.SLNHAN.HeaderText = "Số lượng thực tế";
            this.SLNHAN.Name = "SLNHAN";
            this.SLNHAN.Width = 150;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá nhập";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 120;
            // 
            // SOHIEUDH
            // 
            this.SOHIEUDH.DataPropertyName = "SOHIEUDH";
            this.SOHIEUDH.HeaderText = "Số hiệu đh";
            this.SOHIEUDH.Name = "SOHIEUDH";
            this.SOHIEUDH.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng chứng từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng thực tế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(384, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(384, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số hiệu đơn hàng";
            // 
            // txtSOPN
            // 
            this.txtSOPN.Location = new System.Drawing.Point(188, 114);
            this.txtSOPN.Name = "txtSOPN";
            this.txtSOPN.Size = new System.Drawing.Size(120, 20);
            this.txtSOPN.TabIndex = 7;
            // 
            // txtMAHH
            // 
            this.txtMAHH.Location = new System.Drawing.Point(188, 148);
            this.txtMAHH.Name = "txtMAHH";
            this.txtMAHH.Size = new System.Drawing.Size(120, 20);
            this.txtMAHH.TabIndex = 8;
            // 
            // txtSLGIAO
            // 
            this.txtSLGIAO.Location = new System.Drawing.Point(188, 184);
            this.txtSLGIAO.Name = "txtSLGIAO";
            this.txtSLGIAO.Size = new System.Drawing.Size(120, 20);
            this.txtSLGIAO.TabIndex = 9;
            // 
            // txtSLNHAN
            // 
            this.txtSLNHAN.Location = new System.Drawing.Point(188, 221);
            this.txtSLNHAN.Name = "txtSLNHAN";
            this.txtSLNHAN.Size = new System.Drawing.Size(120, 20);
            this.txtSLNHAN.TabIndex = 10;
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Location = new System.Drawing.Point(536, 125);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Size = new System.Drawing.Size(120, 20);
            this.txtDONGIA.TabIndex = 11;
            // 
            // txtSOHIEUDH
            // 
            this.txtSOHIEUDH.Location = new System.Drawing.Point(536, 184);
            this.txtSOHIEUDH.Name = "txtSOHIEUDH";
            this.txtSOHIEUDH.Size = new System.Drawing.Size(120, 20);
            this.txtSOHIEUDH.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(390, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(497, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(599, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(805, 148);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(718, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tìm Kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(274, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chi tiết phiếu nhập";
            // 
            // FrmChiTiet_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(944, 566);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSOHIEUDH);
            this.Controls.Add(this.txtDONGIA);
            this.Controls.Add(this.txtSLNHAN);
            this.Controls.Add(this.txtSLGIAO);
            this.Controls.Add(this.txtMAHH);
            this.Controls.Add(this.txtSOPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmChiTiet_PhieuNhap";
            this.Text = "FrmChiTiet_PhieuNhap";
            this.Load += new System.EventHandler(this.FrmChiTiet_PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLGIAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOHIEUDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSOPN;
        private System.Windows.Forms.TextBox txtMAHH;
        private System.Windows.Forms.TextBox txtSLGIAO;
        private System.Windows.Forms.TextBox txtSLNHAN;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.TextBox txtSOHIEUDH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}