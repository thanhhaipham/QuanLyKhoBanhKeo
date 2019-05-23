namespace ThucTapNhom
{
    partial class BaoCaoDoanhThu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSPBC = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtSPX = new System.Windows.Forms.TextBox();
            this.dtpTN = new System.Windows.Forms.DateTimePicker();
            this.dtpDN = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBCDT = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.SOPBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUNGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DENNGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SP Báo Cáo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(230, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(529, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số PX:";
            // 
            // txtSPBC
            // 
            this.txtSPBC.Location = new System.Drawing.Point(100, 21);
            this.txtSPBC.Name = "txtSPBC";
            this.txtSPBC.Size = new System.Drawing.Size(100, 20);
            this.txtSPBC.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(100, 70);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 20);
            this.txtMK.TabIndex = 6;
            // 
            // txtSPX
            // 
            this.txtSPX.Location = new System.Drawing.Point(593, 25);
            this.txtSPX.Name = "txtSPX";
            this.txtSPX.Size = new System.Drawing.Size(100, 20);
            this.txtSPX.TabIndex = 7;
            // 
            // dtpTN
            // 
            this.dtpTN.Location = new System.Drawing.Point(294, 22);
            this.dtpTN.Name = "dtpTN";
            this.dtpTN.Size = new System.Drawing.Size(200, 20);
            this.dtpTN.TabIndex = 8;
            // 
            // dtpDN
            // 
            this.dtpDN.Location = new System.Drawing.Point(294, 70);
            this.dtpDN.Name = "dtpDN";
            this.dtpDN.Size = new System.Drawing.Size(200, 20);
            this.dtpDN.TabIndex = 9;
            // 
            // dataGridViewBCDT
            // 
            this.dataGridViewBCDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBCDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPBC,
            this.MAKHO,
            this.TUNGAY,
            this.DENNGAY,
            this.SOPX});
            this.dataGridViewBCDT.Location = new System.Drawing.Point(1, 217);
            this.dataGridViewBCDT.Name = "dataGridViewBCDT";
            this.dataGridViewBCDT.Size = new System.Drawing.Size(797, 231);
            this.dataGridViewBCDT.TabIndex = 10;
            this.dataGridViewBCDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBCDT_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Turquoise;
            this.btnThem.Location = new System.Drawing.Point(29, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Turquoise;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(167, 151);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Turquoise;
            this.btnXoa.Location = new System.Drawing.Point(310, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Turquoise;
            this.btnTK.Location = new System.Drawing.Point(463, 151);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 14;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = false;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(581, 153);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 20);
            this.txtTK.TabIndex = 15;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // SOPBC
            // 
            this.SOPBC.DataPropertyName = "SOPBC";
            this.SOPBC.HeaderText = "SP Báo Cáo";
            this.SOPBC.Name = "SOPBC";
            this.SOPBC.Width = 150;
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.Width = 150;
            // 
            // TUNGAY
            // 
            this.TUNGAY.DataPropertyName = "TUNGAY";
            this.TUNGAY.HeaderText = "Từ Ngày";
            this.TUNGAY.Name = "TUNGAY";
            this.TUNGAY.Width = 150;
            // 
            // DENNGAY
            // 
            this.DENNGAY.DataPropertyName = "DENNGAY";
            this.DENNGAY.HeaderText = "Đến Ngày";
            this.DENNGAY.Name = "DENNGAY";
            this.DENNGAY.Width = 150;
            // 
            // SOPX
            // 
            this.SOPX.DataPropertyName = "SOPX";
            this.SOPX.HeaderText = "Số PX";
            this.SOPX.Name = "SOPX";
            this.SOPX.Width = 160;
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewBCDT);
            this.Controls.Add(this.dtpDN);
            this.Controls.Add(this.dtpTN);
            this.Controls.Add(this.txtSPX);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtSPBC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSPBC;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtSPX;
        private System.Windows.Forms.DateTimePicker dtpTN;
        private System.Windows.Forms.DateTimePicker dtpDN;
        private System.Windows.Forms.DataGridView dataGridViewBCDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DENNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPX;
    }
}