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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            nam = new DataGridViewTextBoxColumn();
            loaihinh = new DataGridViewTextBoxColumn();
            khuvuc = new DataGridViewTextBoxColumn();
            sohoso = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 40);
            label1.Name = "label1";
            label1.Size = new Size(240, 22);
            label1.TabIndex = 1;
            label1.Text = "BẢNG THỐNG KÊ HỒ SƠ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nam, loaihinh, khuvuc, sohoso });
            dataGridView1.Location = new Point(134, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(650, 458);
            dataGridView1.TabIndex = 0;
            // 
            // nam
            // 
            nam.HeaderText = "Năm";
            nam.Name = "nam";
            // 
            // loaihinh
            // 
            loaihinh.HeaderText = "Loại Hình";
            loaihinh.Name = "loaihinh";
            loaihinh.Width = 150;
            // 
            // khuvuc
            // 
            khuvuc.HeaderText = "Khu Vực (Xã)";
            khuvuc.Name = "khuvuc";
            khuvuc.Width = 250;
            // 
            // sohoso
            // 
            sohoso.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sohoso.HeaderText = "Số Hồ Sơ KBM";
            sohoso.Name = "sohoso";
            sohoso.Width = 108;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.CausesValidation = false;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 542);
            panel1.TabIndex = 1;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(988, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ThongKe";
            Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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