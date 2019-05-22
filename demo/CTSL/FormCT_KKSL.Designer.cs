namespace ThucTapNhom
{
    partial class FormCT_KKSL
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
            this.SOPSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHUONGTHUCKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSOPSL = new System.Windows.Forms.TextBox();
            this.txtMAHH = new System.Windows.Forms.TextBox();
            this.txtPHUONGTHUCKK = new System.Windows.Forms.TextBox();
            this.txtSOLUONGCT = new System.Windows.Forms.TextBox();
            this.txtSOLUONGTT = new System.Windows.Forms.TextBox();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTIMKIEM_CTKKSL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPSL,
            this.MAHH,
            this.PHUONGTHUCKK,
            this.SOLUONGCT,
            this.SOLUONGTT,
            this.GHICHU});
            this.dataGridView1.Location = new System.Drawing.Point(0, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SOPSL
            // 
            this.SOPSL.DataPropertyName = "SOPSL";
            this.SOPSL.HeaderText = "Số phiếu số lượng";
            this.SOPSL.Name = "SOPSL";
            this.SOPSL.Width = 125;
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hàng hóa";
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 125;
            // 
            // PHUONGTHUCKK
            // 
            this.PHUONGTHUCKK.DataPropertyName = "PHUONGTHUCKK";
            this.PHUONGTHUCKK.HeaderText = "Phương thức kiểm kê";
            this.PHUONGTHUCKK.Name = "PHUONGTHUCKK";
            this.PHUONGTHUCKK.Width = 125;
            // 
            // SOLUONGCT
            // 
            this.SOLUONGCT.DataPropertyName = "SOLUONGCT";
            this.SOLUONGCT.HeaderText = "Số lượng chứng từ";
            this.SOLUONGCT.Name = "SOLUONGCT";
            this.SOLUONGCT.Width = 125;
            // 
            // SOLUONGTT
            // 
            this.SOLUONGTT.DataPropertyName = "SOLUONGTT";
            this.SOLUONGTT.HeaderText = "Số lượng thực tế";
            this.SOLUONGTT.Name = "SOLUONGTT";
            this.SOLUONGTT.Width = 125;
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phương thức kiểm kê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng chứng từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng thực tế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú";
            // 
            // txtSOPSL
            // 
            this.txtSOPSL.Location = new System.Drawing.Point(164, 19);
            this.txtSOPSL.Name = "txtSOPSL";
            this.txtSOPSL.Size = new System.Drawing.Size(100, 22);
            this.txtSOPSL.TabIndex = 7;
            // 
            // txtMAHH
            // 
            this.txtMAHH.Location = new System.Drawing.Point(164, 48);
            this.txtMAHH.Name = "txtMAHH";
            this.txtMAHH.Size = new System.Drawing.Size(100, 22);
            this.txtMAHH.TabIndex = 8;
            // 
            // txtPHUONGTHUCKK
            // 
            this.txtPHUONGTHUCKK.Location = new System.Drawing.Point(164, 79);
            this.txtPHUONGTHUCKK.Name = "txtPHUONGTHUCKK";
            this.txtPHUONGTHUCKK.Size = new System.Drawing.Size(100, 22);
            this.txtPHUONGTHUCKK.TabIndex = 9;
            // 
            // txtSOLUONGCT
            // 
            this.txtSOLUONGCT.Location = new System.Drawing.Point(164, 111);
            this.txtSOLUONGCT.Name = "txtSOLUONGCT";
            this.txtSOLUONGCT.Size = new System.Drawing.Size(100, 22);
            this.txtSOLUONGCT.TabIndex = 10;
            // 
            // txtSOLUONGTT
            // 
            this.txtSOLUONGTT.Location = new System.Drawing.Point(164, 148);
            this.txtSOLUONGTT.Name = "txtSOLUONGTT";
            this.txtSOLUONGTT.Size = new System.Drawing.Size(100, 22);
            this.txtSOLUONGTT.TabIndex = 11;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(164, 184);
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(100, 22);
            this.txtGHICHU.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(108, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(205, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 24);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(447, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "CHI TIẾT PHIẾU KIỂM KÊ SỐ LƯỢNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "TÌM KIẾM";
            // 
            // txtTIMKIEM_CTKKSL
            // 
            this.txtTIMKIEM_CTKKSL.Location = new System.Drawing.Point(538, 69);
            this.txtTIMKIEM_CTKKSL.Name = "txtTIMKIEM_CTKKSL";
            this.txtTIMKIEM_CTKKSL.Size = new System.Drawing.Size(250, 22);
            this.txtTIMKIEM_CTKKSL.TabIndex = 18;
            this.txtTIMKIEM_CTKKSL.TextChanged += new System.EventHandler(this.txtTIMKIEM_CTKKSL_TextChanged);
            // 
            // FormCT_KKSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTIMKIEM_CTKKSL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGHICHU);
            this.Controls.Add(this.txtSOLUONGTT);
            this.Controls.Add(this.txtSOLUONGCT);
            this.Controls.Add(this.txtPHUONGTHUCKK);
            this.Controls.Add(this.txtMAHH);
            this.Controls.Add(this.txtSOPSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCT_KKSL";
            this.Text = "CT_KKSL";
            this.Load += new System.EventHandler(this.FormCT_KKSL_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSOPSL;
        private System.Windows.Forms.TextBox txtMAHH;
        private System.Windows.Forms.TextBox txtPHUONGTHUCKK;
        private System.Windows.Forms.TextBox txtSOLUONGCT;
        private System.Windows.Forms.TextBox txtSOLUONGTT;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTIMKIEM_CTKKSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHUONGTHUCKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}