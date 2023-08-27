namespace ChuyenDoiSo1
{
    partial class QTMT_THONGKE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 714);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kế Quan Trắc Môi Trường";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nam,
            this.loaihinh,
            this.khuvuc,
            this.sohoso});
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(710, 468);
            this.dataGridView1.TabIndex = 1;
            // 
            // nam
            // 
            this.nam.HeaderText = "Số QTMT";
            this.nam.Name = "nam";
            // 
            // loaihinh
            // 
            this.loaihinh.HeaderText = "Loại Hình";
            this.loaihinh.Name = "loaihinh";
            this.loaihinh.ToolTipText = "Thông Tin";
            this.loaihinh.Width = 150;
            // 
            // khuvuc
            // 
            this.khuvuc.HeaderText = "Khu Vực (Dự Án)";
            this.khuvuc.Name = "khuvuc";
            this.khuvuc.Width = 250;
            // 
            // sohoso
            // 
            this.sohoso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sohoso.FillWeight = 200F;
            this.sohoso.HeaderText = "Văn Bản";
            this.sohoso.Name = "sohoso";
            this.sohoso.Width = 74;
            // 
            // QTMT_THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.panel1);
            this.Name = "QTMT_THONGKE";
            this.Text = "QTMT_THONGKE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nam;
        private DataGridViewTextBoxColumn loaihinh;
        private DataGridViewTextBoxColumn khuvuc;
        private DataGridViewTextBoxColumn sohoso;
    }
}