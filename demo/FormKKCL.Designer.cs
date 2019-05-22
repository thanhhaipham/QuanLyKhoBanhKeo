namespace ThucTapNhom
{
    partial class FormKKCL
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
            this.SOPCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOPCL = new System.Windows.Forms.TextBox();
            this.txtNGAYKK = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTIMKIEM_KKCL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPCL,
            this.NGAYKK,
            this.MAKHO,
            this.MANV});
            this.dataGridView1.Location = new System.Drawing.Point(1, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SOPCL
            // 
            this.SOPCL.DataPropertyName = "SOPCL";
            this.SOPCL.HeaderText = "Số phiếu chất lượng";
            this.SOPCL.Name = "SOPCL";
            this.SOPCL.Width = 150;
            // 
            // NGAYKK
            // 
            this.NGAYKK.DataPropertyName = "NGAYKK";
            this.NGAYKK.HeaderText = "Ngày kiểm kê";
            this.NGAYKK.Name = "NGAYKK";
            this.NGAYKK.Width = 200;
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.Width = 150;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu chất lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày kiểm kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // txtSOPCL
            // 
            this.txtSOPCL.Location = new System.Drawing.Point(160, 81);
            this.txtSOPCL.Name = "txtSOPCL";
            this.txtSOPCL.Size = new System.Drawing.Size(100, 22);
            this.txtSOPCL.TabIndex = 5;
            // 
            // txtNGAYKK
            // 
            this.txtNGAYKK.Location = new System.Drawing.Point(160, 116);
            this.txtNGAYKK.Name = "txtNGAYKK";
            this.txtNGAYKK.Size = new System.Drawing.Size(100, 22);
            this.txtNGAYKK.TabIndex = 6;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.Location = new System.Drawing.Point(160, 148);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(100, 22);
            this.txtMAKHO.TabIndex = 7;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(160, 183);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 22);
            this.txtMANV.TabIndex = 8;
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.Lime;
            this.btnTHEM.Location = new System.Drawing.Point(1, 222);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(79, 24);
            this.btnTHEM.TabIndex = 9;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.Yellow;
            this.btnSUA.Location = new System.Drawing.Point(86, 222);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(83, 24);
            this.btnSUA.TabIndex = 10;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.Red;
            this.btnXOA.Location = new System.Drawing.Point(175, 222);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(85, 24);
            this.btnXOA.TabIndex = 11;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "PHIẾU KIỂM KÊ CHẤT LƯỢNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "TÌM KIẾM";
            // 
            // txtTIMKIEM_KKCL
            // 
            this.txtTIMKIEM_KKCL.Location = new System.Drawing.Point(525, 81);
            this.txtTIMKIEM_KKCL.Name = "txtTIMKIEM_KKCL";
            this.txtTIMKIEM_KKCL.Size = new System.Drawing.Size(263, 22);
            this.txtTIMKIEM_KKCL.TabIndex = 14;
            this.txtTIMKIEM_KKCL.TextChanged += new System.EventHandler(this.txtTIMKIEM_KKCL_TextChanged);
            // 
            // FormKKCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTIMKIEM_KKCL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.txtMAKHO);
            this.Controls.Add(this.txtNGAYKK);
            this.Controls.Add(this.txtSOPCL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKKCL";
            this.Text = "FormKKCL";
            this.Load += new System.EventHandler(this.FormKKCL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOPCL;
        private System.Windows.Forms.TextBox txtNGAYKK;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTIMKIEM_KKCL;
    }
}