namespace ChuyenDoiSo1
{
    partial class DoigiaodienForm
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.comboBoxFontFamily = new System.Windows.Forms.ComboBox();
            this.labelFontFamily = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(488, 314);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(155, 45);
            this.buttonApply.TabIndex = 57;
            this.buttonApply.Text = "Áp dụng";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // comboBoxFontFamily
            // 
            this.comboBoxFontFamily.FormattingEnabled = true;
            this.comboBoxFontFamily.Items.AddRange(new object[] {
            "Times New Roman.",
            "Helvetica.",
            "Open Sans.",
            "Tahoma.",
            "Georgia.",
            "Ariel Signature.",
            "Stantic Typeface."});
            this.comboBoxFontFamily.Location = new System.Drawing.Point(258, 234);
            this.comboBoxFontFamily.Name = "comboBoxFontFamily";
            this.comboBoxFontFamily.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFontFamily.TabIndex = 56;
            // 
            // labelFontFamily
            // 
            this.labelFontFamily.AutoSize = true;
            this.labelFontFamily.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFontFamily.Location = new System.Drawing.Point(174, 237);
            this.labelFontFamily.Name = "labelFontFamily";
            this.labelFontFamily.Size = new System.Drawing.Size(78, 20);
            this.labelFontFamily.TabIndex = 55;
            this.labelFontFamily.Text = "Font chữ:";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFontSize.Location = new System.Drawing.Point(174, 183);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(148, 20);
            this.labelFontSize.TabIndex = 54;
            this.labelFontSize.Text = "Chọn kích cỡ chữ :";
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxFontSize.Location = new System.Drawing.Point(328, 180);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFontSize.TabIndex = 53;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Đỏ ",
            "Tím ",
            "Vàng ",
            "Hồng",
            "Đen",
            "Xanh Lá",
            "Xanh Dương",
            "Cam",
            "Tím"});
            this.comboBoxColor.Location = new System.Drawing.Point(291, 126);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(140, 28);
            this.comboBoxColor.TabIndex = 52;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(174, 129);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(111, 20);
            this.labelColor.TabIndex = 51;
            this.labelColor.Text = "Hiển thị màu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(174, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Đổi giao diện:";
            // 
            // DoigiaodienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 408);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxFontFamily);
            this.Controls.Add(this.labelFontFamily);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.comboBoxFontSize);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label6);
            this.Name = "DoigiaodienForm";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApply;
        private ComboBox comboBoxFontFamily;
        private Label labelFontFamily;
        private Label labelFontSize;
        private ComboBox comboBoxFontSize;
        private ComboBox comboBoxColor;
        private Label labelColor;
        private Label label6;
    }
}