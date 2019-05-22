namespace demo
{
    partial class FrmHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiemHH = new System.Windows.Forms.TextBox();
            this.gbThongTinHH = new System.Windows.Forms.GroupBox();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.txtMANCC = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTENHH = new System.Windows.Forms.TextBox();
            this.txtMAHH = new System.Windows.Forms.TextBox();
            this.lblMANCC = new System.Windows.Forms.Label();
            this.lblDONGIA = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblTENHH = new System.Windows.Forms.Label();
            this.lblMAHH = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinHH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.MANCC,
            this.TENHH,
            this.DVT,
            this.DONGIA,
            this.TENNCC});
            this.dataGridView1.Location = new System.Drawing.Point(370, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(553, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(683, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiemHH
            // 
            this.txtTimKiemHH.Location = new System.Drawing.Point(761, 61);
            this.txtTimKiemHH.Name = "txtTimKiemHH";
            this.txtTimKiemHH.Size = new System.Drawing.Size(121, 20);
            this.txtTimKiemHH.TabIndex = 3;
            this.txtTimKiemHH.TextChanged += new System.EventHandler(this.txtTimKiemHH_TextChanged);
            // 
            // gbThongTinHH
            // 
            this.gbThongTinHH.Controls.Add(this.txtDONGIA);
            this.gbThongTinHH.Controls.Add(this.txtMANCC);
            this.gbThongTinHH.Controls.Add(this.txtDVT);
            this.gbThongTinHH.Controls.Add(this.txtTENHH);
            this.gbThongTinHH.Controls.Add(this.txtMAHH);
            this.gbThongTinHH.Controls.Add(this.lblMANCC);
            this.gbThongTinHH.Controls.Add(this.lblDONGIA);
            this.gbThongTinHH.Controls.Add(this.lblDVT);
            this.gbThongTinHH.Controls.Add(this.lblTENHH);
            this.gbThongTinHH.Controls.Add(this.lblMAHH);
            this.gbThongTinHH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbThongTinHH.Location = new System.Drawing.Point(33, 20);
            this.gbThongTinHH.Name = "gbThongTinHH";
            this.gbThongTinHH.Size = new System.Drawing.Size(315, 200);
            this.gbThongTinHH.TabIndex = 4;
            this.gbThongTinHH.TabStop = false;
            this.gbThongTinHH.Text = "Thông tin hàng hóa";
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Location = new System.Drawing.Point(83, 129);
            this.txtDONGIA.Multiline = true;
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Size = new System.Drawing.Size(72, 20);
            this.txtDONGIA.TabIndex = 10;
            // 
            // txtMANCC
            // 
            this.txtMANCC.Location = new System.Drawing.Point(83, 167);
            this.txtMANCC.Name = "txtMANCC";
            this.txtMANCC.Size = new System.Drawing.Size(103, 20);
            this.txtMANCC.TabIndex = 9;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(225, 129);
            this.txtDVT.Multiline = true;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(72, 20);
            this.txtDVT.TabIndex = 7;
            // 
            // txtTENHH
            // 
            this.txtTENHH.Location = new System.Drawing.Point(83, 83);
            this.txtTENHH.Name = "txtTENHH";
            this.txtTENHH.Size = new System.Drawing.Size(135, 20);
            this.txtTENHH.TabIndex = 6;
            // 
            // txtMAHH
            // 
            this.txtMAHH.Location = new System.Drawing.Point(83, 34);
            this.txtMAHH.Name = "txtMAHH";
            this.txtMAHH.Size = new System.Drawing.Size(100, 20);
            this.txtMAHH.TabIndex = 5;
            // 
            // lblMANCC
            // 
            this.lblMANCC.AutoSize = true;
            this.lblMANCC.Location = new System.Drawing.Point(7, 170);
            this.lblMANCC.Name = "lblMANCC";
            this.lblMANCC.Size = new System.Drawing.Size(75, 13);
            this.lblMANCC.TabIndex = 4;
            this.lblMANCC.Text = "Nhà cung cấp";
            // 
            // lblDONGIA
            // 
            this.lblDONGIA.AutoSize = true;
            this.lblDONGIA.Location = new System.Drawing.Point(18, 132);
            this.lblDONGIA.Name = "lblDONGIA";
            this.lblDONGIA.Size = new System.Drawing.Size(44, 13);
            this.lblDONGIA.TabIndex = 3;
            this.lblDONGIA.Text = "Đơn giá";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(171, 132);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(29, 13);
            this.lblDVT.TabIndex = 2;
            this.lblDVT.Text = "ĐVT";
            // 
            // lblTENHH
            // 
            this.lblTENHH.AutoSize = true;
            this.lblTENHH.Location = new System.Drawing.Point(7, 83);
            this.lblTENHH.Name = "lblTENHH";
            this.lblTENHH.Size = new System.Drawing.Size(74, 13);
            this.lblTENHH.TabIndex = 1;
            this.lblTENHH.Text = "Tên hàng hóa";
            // 
            // lblMAHH
            // 
            this.lblMAHH.AutoSize = true;
            this.lblMAHH.Location = new System.Drawing.Point(7, 37);
            this.lblMAHH.Name = "lblMAHH";
            this.lblMAHH.Size = new System.Drawing.Size(70, 13);
            this.lblMAHH.TabIndex = 0;
            this.lblMAHH.Text = "Mã hàng hóa";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(152, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(267, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hàng hóa";
            this.MAHH.Name = "MAHH";
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cc";
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = false;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên hàng hóa";
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 150;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐVT";
            this.DVT.Name = "DVT";
            this.DVT.Width = 80;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên nhà cc";
            this.TENNCC.Name = "TENNCC";
            // 
            // FrmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(944, 566);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbThongTinHH);
            this.Controls.Add(this.txtTimKiemHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHangHoa";
            this.Load += new System.EventHandler(this.FrmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinHH.ResumeLayout(false);
            this.gbThongTinHH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiemHH;
        private System.Windows.Forms.GroupBox gbThongTinHH;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTENHH;
        private System.Windows.Forms.TextBox txtMAHH;
        private System.Windows.Forms.Label lblMANCC;
        private System.Windows.Forms.Label lblDONGIA;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblTENHH;
        private System.Windows.Forms.Label lblMAHH;
        private System.Windows.Forms.TextBox txtMANCC;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
    }
}