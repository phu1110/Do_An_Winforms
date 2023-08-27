namespace ChuyenDoiSo1
{
    partial class ThongKe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(351, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG THỐNG KÊ HỒ SƠ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nam,
            this.loaihinh,
            this.khuvuc,
            this.sohoso});
            this.dataGridView1.Location = new System.Drawing.Point(134, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 458);
            this.dataGridView1.TabIndex = 0;
            // 
            // nam
            // 
            this.nam.HeaderText = "Năm";
            this.nam.Name = "nam";
            // 
            // loaihinh
            // 
            this.loaihinh.HeaderText = "Loại Hình";
            this.loaihinh.Name = "loaihinh";
            this.loaihinh.Width = 150;
            // 
            // khuvuc
            // 
            this.khuvuc.HeaderText = "Khu Vực (Xã)";
            this.khuvuc.Name = "khuvuc";
            this.khuvuc.Width = 250;
            // 
            // sohoso
            // 
            this.sohoso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sohoso.HeaderText = "Số Hồ Sơ KBM";
            this.sohoso.Name = "sohoso";
            this.sohoso.Width = 108;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 544);
            this.panel1.TabIndex = 1;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nam;
        private DataGridViewTextBoxColumn loaihinh;
        private DataGridViewTextBoxColumn khuvuc;
        private DataGridViewTextBoxColumn sohoso;
        private Panel panel1;
    }
}