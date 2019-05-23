namespace ThucTapNhom
{
    partial class ChiTietPhieuXuat
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSPX = new System.Windows.Forms.TextBox();
            this.txtMHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLX = new System.Windows.Forms.TextBox();
            this.dataGridViewCHITIET = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.SOPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIET)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phiếu Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(273, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hàng Hóa:";
            // 
            // txtSPX
            // 
            this.txtSPX.Location = new System.Drawing.Point(105, 28);
            this.txtSPX.Name = "txtSPX";
            this.txtSPX.Size = new System.Drawing.Size(100, 20);
            this.txtSPX.TabIndex = 4;
            // 
            // txtMHH
            // 
            this.txtMHH.Location = new System.Drawing.Point(366, 28);
            this.txtMHH.Name = "txtMHH";
            this.txtMHH.Size = new System.Drawing.Size(100, 20);
            this.txtMHH.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(553, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Lượng Xuất:";
            // 
            // txtSLX
            // 
            this.txtSLX.Location = new System.Drawing.Point(640, 27);
            this.txtSLX.Name = "txtSLX";
            this.txtSLX.Size = new System.Drawing.Size(100, 20);
            this.txtSLX.TabIndex = 10;
            // 
            // dataGridViewCHITIET
            // 
            this.dataGridViewCHITIET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCHITIET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPX,
            this.MAHH,
            this.SLXUAT});
            this.dataGridViewCHITIET.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCHITIET.Name = "dataGridViewCHITIET";
            this.dataGridViewCHITIET.Size = new System.Drawing.Size(744, 267);
            this.dataGridViewCHITIET.TabIndex = 12;
            this.dataGridViewCHITIET.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCHITIET_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Location = new System.Drawing.Point(54, 132);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightGreen;
            this.btnSua.Location = new System.Drawing.Point(172, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(318, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Location = new System.Drawing.Point(476, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(569, 132);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 20);
            this.txtTK.TabIndex = 18;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // SOPX
            // 
            this.SOPX.DataPropertyName = "SOPX";
            this.SOPX.HeaderText = "Số Phiếu Xuất";
            this.SOPX.Name = "SOPX";
            this.SOPX.Width = 250;
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã Hàng Hóa";
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 250;
            // 
            // SLXUAT
            // 
            this.SLXUAT.DataPropertyName = "SLXUAT";
            this.SLXUAT.HeaderText = "Số Lượng Xuất";
            this.SLXUAT.Name = "SLXUAT";
            this.SLXUAT.Width = 250;
            // 
            // ChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewCHITIET);
            this.Controls.Add(this.txtSLX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMHH);
            this.Controls.Add(this.txtSPX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietPhieuXuat";
            this.Text = "ChiTietPhieuXuat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCHITIET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSPX;
        private System.Windows.Forms.TextBox txtMHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLX;
        private System.Windows.Forms.DataGridView dataGridViewCHITIET;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXUAT;
    }
}

