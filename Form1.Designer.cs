namespace MSC_control
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Length = new System.Windows.Forms.Label();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_Barcode = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Volume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Index = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(305, 92);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(38, 12);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length";
            // 
            // textBox_Length
            // 
            this.textBox_Length.Enabled = false;
            this.textBox_Length.HideSelection = false;
            this.textBox_Length.Location = new System.Drawing.Point(278, 116);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(100, 22);
            this.textBox_Length.TabIndex = 1;
            // 
            // textBox_Width
            // 
            this.textBox_Width.Enabled = false;
            this.textBox_Width.Location = new System.Drawing.Point(32, 116);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(100, 22);
            this.textBox_Width.TabIndex = 3;
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(58, 92);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(34, 12);
            this.Width.TabIndex = 2;
            this.Width.Text = "Width";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Enabled = false;
            this.textBox_Height.Location = new System.Drawing.Point(157, 116);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(100, 22);
            this.textBox_Height.TabIndex = 5;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(183, 92);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(36, 12);
            this.Height.TabIndex = 4;
            this.Height.Text = "Height";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(21, 293);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 12);
            this.label23.TabIndex = 40;
            this.label23.Text = "Scanner status";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(97, 293);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 41;
            this.label24.Text = "未连接";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 46;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(161, 292);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 12);
            this.label25.TabIndex = 47;
            this.label25.Text = "IP";
            // 
            // textBox_Barcode
            // 
            this.textBox_Barcode.Enabled = false;
            this.textBox_Barcode.HideSelection = false;
            this.textBox_Barcode.Location = new System.Drawing.Point(157, 53);
            this.textBox_Barcode.Name = "textBox_Barcode";
            this.textBox_Barcode.Size = new System.Drawing.Size(100, 22);
            this.textBox_Barcode.TabIndex = 49;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(183, 29);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(44, 12);
            this.Barcode.TabIndex = 50;
            this.Barcode.Text = "Barcode";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Enabled = false;
            this.textBox_Weight.Location = new System.Drawing.Point(157, 188);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(100, 22);
            this.textBox_Weight.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "Weight";
            // 
            // textBox_Volume
            // 
            this.textBox_Volume.Enabled = false;
            this.textBox_Volume.Location = new System.Drawing.Point(32, 188);
            this.textBox_Volume.Name = "textBox_Volume";
            this.textBox_Volume.Size = new System.Drawing.Size(100, 22);
            this.textBox_Volume.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 51;
            this.label2.Text = "Volume";
            // 
            // textBox_Index
            // 
            this.textBox_Index.Enabled = false;
            this.textBox_Index.HideSelection = false;
            this.textBox_Index.Location = new System.Drawing.Point(32, 53);
            this.textBox_Index.Name = "textBox_Index";
            this.textBox_Index.Size = new System.Drawing.Size(100, 22);
            this.textBox_Index.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Index);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Volume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.textBox_Barcode);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.Length);
            this.Name = "Form1";
            this.Text = "CLV62x barcode scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_Barcode;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Index;
        private System.Windows.Forms.Label label3;
    }
}

