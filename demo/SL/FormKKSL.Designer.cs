namespace ThucTapNhom
{
    partial class FormKKSL
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
            this.txtSOPSL = new System.Windows.Forms.TextBox();
            this.txtNGAYKK = new System.Windows.Forms.TextBox();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.SOPSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTIMKIEM_KKSL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPSL,
            this.NGAYKK,
            this.MAKHO,
            this.MANV});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSOPSL
            // 
            this.txtSOPSL.Location = new System.Drawing.Point(162, 122);
            this.txtSOPSL.Name = "txtSOPSL";
            this.txtSOPSL.Size = new System.Drawing.Size(100, 22);
            this.txtSOPSL.TabIndex = 1;
            // 
            // txtNGAYKK
            // 
            this.txtNGAYKK.Location = new System.Drawing.Point(162, 155);
            this.txtNGAYKK.Name = "txtNGAYKK";
            this.txtNGAYKK.Size = new System.Drawing.Size(100, 22);
            this.txtNGAYKK.TabIndex = 2;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.Location = new System.Drawing.Point(162, 183);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(100, 22);
            this.txtMAKHO.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(162, 215);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 22);
            this.txtMANV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số phiếu số lượng";
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.Lime;
            this.btnTHEM.Location = new System.Drawing.Point(-1, 252);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(80, 27);
            this.btnTHEM.TabIndex = 6;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày kiểm kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã nhân viên";
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.Yellow;
            this.btnSUA.Location = new System.Drawing.Point(85, 252);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(82, 27);
            this.btnSUA.TabIndex = 10;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.Red;
            this.btnXOA.Location = new System.Drawing.Point(173, 252);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(89, 27);
            this.btnXOA.TabIndex = 11;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // SOPSL
            // 
            this.SOPSL.DataPropertyName = "SOPSL";
            this.SOPSL.HeaderText = "Số phiếu số lượng";
            this.SOPSL.Name = "SOPSL";
            this.SOPSL.Width = 150;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "PHIẾU KIỂM KÊ SỐ LƯỢNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "TÌM KIẾM";
            // 
            // txtTIMKIEM_KKSL
            // 
            this.txtTIMKIEM_KKSL.Location = new System.Drawing.Point(543, 66);
            this.txtTIMKIEM_KKSL.Name = "txtTIMKIEM_KKSL";
            this.txtTIMKIEM_KKSL.Size = new System.Drawing.Size(245, 22);
            this.txtTIMKIEM_KKSL.TabIndex = 14;
            this.txtTIMKIEM_KKSL.TextChanged += new System.EventHandler(this.txtTIMKIEM_KKSL_TextChanged);
            // 
            // FormKKSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTIMKIEM_KKSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(this.txtMAKHO);
            this.Controls.Add(this.txtNGAYKK);
            this.Controls.Add(this.txtSOPSL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormKKSL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSOPSL;
        private System.Windows.Forms.TextBox txtNGAYKK;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTIMKIEM_KKSL;
    }
}

