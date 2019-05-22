namespace demo
{
    partial class FrmKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMATK = new System.Windows.Forms.TextBox();
            this.txtDIACHIKHO = new System.Windows.Forms.TextBox();
            this.txtTENKHO = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnK6 = new System.Windows.Forms.Button();
            this.btnK7 = new System.Windows.Forms.Button();
            this.btnK9 = new System.Windows.Forms.Button();
            this.btnK8 = new System.Windows.Forms.Button();
            this.btnK10 = new System.Windows.Forms.Button();
            this.dataGridViewHHTK = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKhoTong = new System.Windows.Forms.Button();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHHTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHO,
            this.TENKHO,
            this.DIACHIKHO,
            this.TENNV,
            this.MATK});
            this.dataGridView1.Location = new System.Drawing.Point(402, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 310);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMATK);
            this.groupBox1.Controls.Add(this.txtDIACHIKHO);
            this.groupBox1.Controls.Add(this.txtTENKHO);
            this.groupBox1.Controls.Add(this.txtMAKHO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(402, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // txtMATK
            // 
            this.txtMATK.Location = new System.Drawing.Point(97, 144);
            this.txtMATK.Name = "txtMATK";
            this.txtMATK.Size = new System.Drawing.Size(119, 20);
            this.txtMATK.TabIndex = 7;
            // 
            // txtDIACHIKHO
            // 
            this.txtDIACHIKHO.Location = new System.Drawing.Point(97, 107);
            this.txtDIACHIKHO.Name = "txtDIACHIKHO";
            this.txtDIACHIKHO.Size = new System.Drawing.Size(119, 20);
            this.txtDIACHIKHO.TabIndex = 6;
            // 
            // txtTENKHO
            // 
            this.txtTENKHO.Location = new System.Drawing.Point(97, 66);
            this.txtTENKHO.Name = "txtTENKHO";
            this.txtTENKHO.Size = new System.Drawing.Size(119, 20);
            this.txtTENKHO.TabIndex = 5;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.Location = new System.Drawing.Point(97, 32);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(119, 20);
            this.txtMAKHO.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thủ kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kho";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(699, 68);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(699, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 27);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(699, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 27);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(699, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(778, 218);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(584, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông tin chi nhánh kho";
            // 
            // btnK6
            // 
            this.btnK6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnK6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnK6.Location = new System.Drawing.Point(12, 19);
            this.btnK6.Name = "btnK6";
            this.btnK6.Size = new System.Drawing.Size(98, 94);
            this.btnK6.TabIndex = 8;
            this.btnK6.Text = "KHO SỐ 6";
            this.btnK6.UseVisualStyleBackColor = false;
            this.btnK6.Click += new System.EventHandler(this.btnK6_Click);
            // 
            // btnK7
            // 
            this.btnK7.BackColor = System.Drawing.Color.Yellow;
            this.btnK7.Location = new System.Drawing.Point(129, 19);
            this.btnK7.Name = "btnK7";
            this.btnK7.Size = new System.Drawing.Size(98, 94);
            this.btnK7.TabIndex = 9;
            this.btnK7.Text = "KHO SỐ 7";
            this.btnK7.UseVisualStyleBackColor = false;
            this.btnK7.Click += new System.EventHandler(this.btnK7_Click);
            // 
            // btnK9
            // 
            this.btnK9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnK9.Location = new System.Drawing.Point(12, 132);
            this.btnK9.Name = "btnK9";
            this.btnK9.Size = new System.Drawing.Size(98, 91);
            this.btnK9.TabIndex = 10;
            this.btnK9.Text = "KHO SỐ 9";
            this.btnK9.UseVisualStyleBackColor = false;
            this.btnK9.Click += new System.EventHandler(this.btnK9_Click);
            // 
            // btnK8
            // 
            this.btnK8.BackColor = System.Drawing.Color.Blue;
            this.btnK8.Location = new System.Drawing.Point(259, 19);
            this.btnK8.Name = "btnK8";
            this.btnK8.Size = new System.Drawing.Size(98, 94);
            this.btnK8.TabIndex = 11;
            this.btnK8.Text = "KHO SỐ 8";
            this.btnK8.UseVisualStyleBackColor = false;
            this.btnK8.Click += new System.EventHandler(this.btnK8_Click);
            // 
            // btnK10
            // 
            this.btnK10.BackColor = System.Drawing.Color.Fuchsia;
            this.btnK10.Location = new System.Drawing.Point(129, 134);
            this.btnK10.Name = "btnK10";
            this.btnK10.Size = new System.Drawing.Size(98, 89);
            this.btnK10.TabIndex = 12;
            this.btnK10.Text = "KHO SỐ 10";
            this.btnK10.UseVisualStyleBackColor = false;
            this.btnK10.Click += new System.EventHandler(this.btnK10_Click);
            // 
            // dataGridViewHHTK
            // 
            this.dataGridViewHHTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHHTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.TENHH,
            this.SOLUONG});
            this.dataGridViewHHTK.Location = new System.Drawing.Point(12, 256);
            this.dataGridViewHHTK.Name = "dataGridViewHHTK";
            this.dataGridViewHHTK.Size = new System.Drawing.Size(345, 310);
            this.dataGridViewHHTK.TabIndex = 13;
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hh";
            this.MAHH.Name = "MAHH";
            this.MAHH.Visible = false;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên hàng hóa";
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 150;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 150;
            // 
            // btnKhoTong
            // 
            this.btnKhoTong.BackColor = System.Drawing.Color.Silver;
            this.btnKhoTong.Location = new System.Drawing.Point(259, 134);
            this.btnKhoTong.Name = "btnKhoTong";
            this.btnKhoTong.Size = new System.Drawing.Size(98, 89);
            this.btnKhoTong.TabIndex = 14;
            this.btnKhoTong.Text = "KHO TỔNG";
            this.btnKhoTong.UseVisualStyleBackColor = false;
            this.btnKhoTong.Click += new System.EventHandler(this.btnKhoTong_Click);
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã kho";
            this.MAKHO.Name = "MAKHO";
            // 
            // TENKHO
            // 
            this.TENKHO.DataPropertyName = "TENKHO";
            this.TENKHO.HeaderText = "Tên kho";
            this.TENKHO.Name = "TENKHO";
            this.TENKHO.Width = 150;
            // 
            // DIACHIKHO
            // 
            this.DIACHIKHO.DataPropertyName = "DIACHIKHO";
            this.DIACHIKHO.HeaderText = "Địa chỉ";
            this.DIACHIKHO.Name = "DIACHIKHO";
            this.DIACHIKHO.Width = 150;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên thủ kho";
            this.TENNV.Name = "TENNV";
            // 
            // MATK
            // 
            this.MATK.DataPropertyName = "MATK";
            this.MATK.HeaderText = "MÃ thỦ kho";
            this.MATK.Name = "MATK";
            this.MATK.Visible = false;
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(944, 566);
            this.Controls.Add(this.btnKhoTong);
            this.Controls.Add(this.dataGridViewHHTK);
            this.Controls.Add(this.btnK10);
            this.Controls.Add(this.btnK8);
            this.Controls.Add(this.btnK9);
            this.Controls.Add(this.btnK7);
            this.Controls.Add(this.btnK6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKho";
            this.Load += new System.EventHandler(this.FrmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHHTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMATK;
        private System.Windows.Forms.TextBox txtDIACHIKHO;
        private System.Windows.Forms.TextBox txtTENKHO;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnK6;
        private System.Windows.Forms.Button btnK7;
        private System.Windows.Forms.Button btnK9;
        private System.Windows.Forms.Button btnK8;
        private System.Windows.Forms.Button btnK10;
        private System.Windows.Forms.DataGridView dataGridViewHHTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.Button btnKhoTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATK;
    }
}