namespace ThucTapNhom
{
    partial class PhieuXuat
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
            this.txtSPX = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTKH = new System.Windows.Forms.TextBox();
            this.dtpNX = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPX = new System.Windows.Forms.DataGridView();
            this.SOPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phiếu Xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // txtSPX
            // 
            this.txtSPX.Location = new System.Drawing.Point(165, 37);
            this.txtSPX.Name = "txtSPX";
            this.txtSPX.Size = new System.Drawing.Size(100, 20);
            this.txtSPX.TabIndex = 4;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(611, 37);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 20);
            this.txtMK.TabIndex = 6;
            // 
            // txtTKH
            // 
            this.txtTKH.Location = new System.Drawing.Point(611, 83);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.Size = new System.Drawing.Size(100, 20);
            this.txtTKH.TabIndex = 7;
            // 
            // dtpNX
            // 
            this.dtpNX.Location = new System.Drawing.Point(165, 86);
            this.dtpNX.Name = "dtpNX";
            this.dtpNX.Size = new System.Drawing.Size(200, 20);
            this.dtpNX.TabIndex = 8;
            // 
            // dataGridViewPX
            // 
            this.dataGridViewPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPX,
            this.NGAYXUAT,
            this.MAKHO,
            this.TENKH});
            this.dataGridViewPX.Location = new System.Drawing.Point(0, 197);
            this.dataGridViewPX.Name = "dataGridViewPX";
            this.dataGridViewPX.Size = new System.Drawing.Size(799, 252);
            this.dataGridViewPX.TabIndex = 9;
            this.dataGridViewPX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPX_CellClick);
            // 
            // SOPX
            // 
            this.SOPX.DataPropertyName = "SOPX";
            this.SOPX.HeaderText = "Số Phiếu Xuất";
            this.SOPX.Name = "SOPX";
            // 
            // NGAYXUAT
            // 
            this.NGAYXUAT.DataPropertyName = "NGAYXUAT";
            this.NGAYXUAT.HeaderText = "Ngày Xuất";
            this.NGAYXUAT.Name = "NGAYXUAT";
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.Name = "TENKH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(527, 145);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 20);
            this.txtTK.TabIndex = 14;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPX);
            this.Controls.Add(this.dtpNX);
            this.Controls.Add(this.txtTKH);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtSPX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuXuat";
            this.Text = "PhieuXuat";
            this.Load += new System.EventHandler(this.PhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSPX;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTKH;
        private System.Windows.Forms.DateTimePicker dtpNX;
        private System.Windows.Forms.DataGridView dataGridViewPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTK;
    }
}