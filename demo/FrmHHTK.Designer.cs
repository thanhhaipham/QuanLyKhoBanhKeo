namespace demo
{
    partial class FrmHHTK
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
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENHH,
            this.TENKHO,
            this.SOLUONG});
            this.dataGridView1.Location = new System.Drawing.Point(197, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên kho";
            this.TENHH.Name = "TENHH";
            // 
            // TENKHO
            // 
            this.TENKHO.DataPropertyName = "TENKHO";
            this.TENKHO.HeaderText = "Tên hàng hóa";
            this.TENKHO.Name = "TENKHO";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng trong kho";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // FrmHHTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmHHTK";
            this.Text = "FrmHHTK";
            this.Load += new System.EventHandler(this.FrmHHTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
    }
}