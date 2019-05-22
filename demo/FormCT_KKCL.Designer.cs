namespace ThucTapNhom
{
    partial class FormCT_KKCL
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
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSPKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSPHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSOPCL = new System.Windows.Forms.TextBox();
            this.txtMAHH = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtSOLUONGSPKT = new System.Windows.Forms.TextBox();
            this.txtSOLUONGSPL = new System.Windows.Forms.TextBox();
            this.txtSOLUONGSPHH = new System.Windows.Forms.TextBox();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTIMKIEM_CTKKCL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPCL,
            this.MAHH,
            this.SOLUONGSPKT,
            this.SOLUONGSPL,
            this.SOLUONGSPHH,
            this.GHICHU});
            this.dataGridView1.Location = new System.Drawing.Point(1, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SOPCL
            // 
            this.SOPCL.DataPropertyName = "SOPCL";
            this.SOPCL.HeaderText = "Số phiếu chất lượng";
            this.SOPCL.Name = "SOPCL";
            this.SOPCL.Width = 125;
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hàng hóa";
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 125;
            // 
            // SOLUONGSPKT
            // 
            this.SOLUONGSPKT.DataPropertyName = "SOLUONGSPKT";
            this.SOLUONGSPKT.HeaderText = "Số lượng sản phẩm kiểm tra";
            this.SOLUONGSPKT.Name = "SOLUONGSPKT";
            this.SOLUONGSPKT.Width = 125;
            // 
            // SOLUONGSPL
            // 
            this.SOLUONGSPL.DataPropertyName = "SOLUONGSPL";
            this.SOLUONGSPL.HeaderText = "Số lượng sản phẩm lỗi";
            this.SOLUONGSPL.Name = "SOLUONGSPL";
            this.SOLUONGSPL.Width = 125;
            // 
            // SOLUONGSPHH
            // 
            this.SOLUONGSPHH.DataPropertyName = "SOLUONGSPHH";
            this.SOLUONGSPHH.HeaderText = "Số lượng sản phẩm hết hạn";
            this.SOLUONGSPHH.Name = "SOLUONGSPHH";
            this.SOLUONGSPHH.Width = 125;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu chất lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng sản phẩm kiểm tra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng sản phẩm lỗi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng sản phẩm hết hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú";
            // 
            // txtSOPCL
            // 
            this.txtSOPCL.Location = new System.Drawing.Point(239, 4);
            this.txtSOPCL.Name = "txtSOPCL";
            this.txtSOPCL.Size = new System.Drawing.Size(100, 22);
            this.txtSOPCL.TabIndex = 7;
            // 
            // txtMAHH
            // 
            this.txtMAHH.Location = new System.Drawing.Point(239, 39);
            this.txtMAHH.Name = "txtMAHH";
            this.txtMAHH.Size = new System.Drawing.Size(100, 22);
            this.txtMAHH.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // txtSOLUONGSPKT
            // 
            this.txtSOLUONGSPKT.Location = new System.Drawing.Point(239, 78);
            this.txtSOLUONGSPKT.Name = "txtSOLUONGSPKT";
            this.txtSOLUONGSPKT.Size = new System.Drawing.Size(100, 22);
            this.txtSOLUONGSPKT.TabIndex = 10;
            // 
            // txtSOLUONGSPL
            // 
            this.txtSOLUONGSPL.Location = new System.Drawing.Point(239, 119);
            this.txtSOLUONGSPL.Name = "txtSOLUONGSPL";
            this.txtSOLUONGSPL.Size = new System.Drawing.Size(100, 22);
            this.txtSOLUONGSPL.TabIndex = 11;
            // 
            // txtSOLUONGSPHH
            // 
            this.txtSOLUONGSPHH.Location = new System.Drawing.Point(239, 162);
            this.txtSOLUONGSPHH.Name = "txtSOLUONGSPHH";
            this.txtSOLUONGSPHH.Size = new System.Drawing.Size(100, 22);
            this.txtSOLUONGSPHH.TabIndex = 12;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(239, 203);
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(100, 22);
            this.txtGHICHU.TabIndex = 13;
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.Chartreuse;
            this.btnTHEM.Location = new System.Drawing.Point(9, 245);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(59, 24);
            this.btnTHEM.TabIndex = 14;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSUA.Location = new System.Drawing.Point(88, 245);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(68, 24);
            this.btnSUA.TabIndex = 15;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.Red;
            this.btnXOA.Location = new System.Drawing.Point(176, 245);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(64, 24);
            this.btnXOA.TabIndex = 16;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "CHI TIẾT PHIẾU KIỂM KÊ CHẤT LƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(444, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "TÌM KIẾM";
            // 
            // txtTIMKIEM_CTKKCL
            // 
            this.txtTIMKIEM_CTKKCL.Location = new System.Drawing.Point(536, 59);
            this.txtTIMKIEM_CTKKCL.Name = "txtTIMKIEM_CTKKCL";
            this.txtTIMKIEM_CTKKCL.Size = new System.Drawing.Size(252, 22);
            this.txtTIMKIEM_CTKKCL.TabIndex = 19;
            this.txtTIMKIEM_CTKKCL.TextChanged += new System.EventHandler(this.txtTIMKIEM_CTKKCL_TextChanged);
            // 
            // FormCT_KKCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTIMKIEM_CTKKCL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtGHICHU);
            this.Controls.Add(this.txtSOLUONGSPHH);
            this.Controls.Add(this.txtSOLUONGSPL);
            this.Controls.Add(this.txtSOLUONGSPKT);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtMAHH);
            this.Controls.Add(this.txtSOPCL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCT_KKCL";
            this.Text = "FormCT_KKCL";
            this.Load += new System.EventHandler(this.FormCT_KKCL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSOPCL;
        private System.Windows.Forms.TextBox txtMAHH;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtSOLUONGSPKT;
        private System.Windows.Forms.TextBox txtSOLUONGSPL;
        private System.Windows.Forms.TextBox txtSOLUONGSPHH;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSPKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSPHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTIMKIEM_CTKKCL;
    }
}