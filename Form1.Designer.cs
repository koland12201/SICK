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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Target = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.listBox_resultAddress = new System.Windows.Forms.ListBox();
            this.listBox_resultData = new System.Windows.Forms.ListBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.checkBox_scanCompleted = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target";
            // 
            // textBox_Target
            // 
            this.textBox_Target.HideSelection = false;
            this.textBox_Target.Location = new System.Drawing.Point(19, 42);
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.Size = new System.Drawing.Size(100, 22);
            this.textBox_Target.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(5, 402);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 40;
            this.label23.Text = "connection:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(62, 403);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 41;
            this.label24.Text = "未连接";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 46;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(126, 404);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 12);
            this.label25.TabIndex = 47;
            this.label25.Text = "IP:";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(19, 70);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(100, 43);
            this.button_Search.TabIndex = 48;
            this.button_Search.Text = "Search!";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // listBox_resultAddress
            // 
            this.listBox_resultAddress.FormattingEnabled = true;
            this.listBox_resultAddress.ItemHeight = 12;
            this.listBox_resultAddress.Location = new System.Drawing.Point(128, 54);
            this.listBox_resultAddress.Name = "listBox_resultAddress";
            this.listBox_resultAddress.Size = new System.Drawing.Size(51, 328);
            this.listBox_resultAddress.TabIndex = 49;
            // 
            // listBox_resultData
            // 
            this.listBox_resultData.FormattingEnabled = true;
            this.listBox_resultData.ItemHeight = 12;
            this.listBox_resultData.Location = new System.Drawing.Point(185, 54);
            this.listBox_resultData.Name = "listBox_resultData";
            this.listBox_resultData.Size = new System.Drawing.Size(403, 328);
            this.listBox_resultData.TabIndex = 50;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(19, 119);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(100, 43);
            this.button_Reset.TabIndex = 51;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // checkBox_scanCompleted
            // 
            this.checkBox_scanCompleted.AutoSize = true;
            this.checkBox_scanCompleted.Enabled = false;
            this.checkBox_scanCompleted.Location = new System.Drawing.Point(385, 28);
            this.checkBox_scanCompleted.Name = "checkBox_scanCompleted";
            this.checkBox_scanCompleted.Size = new System.Drawing.Size(97, 16);
            this.checkBox_scanCompleted.TabIndex = 52;
            this.checkBox_scanCompleted.Text = "Scan completed";
            this.checkBox_scanCompleted.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(488, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox_scanCompleted);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.listBox_resultData);
            this.Controls.Add(this.listBox_resultAddress);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox_Target);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Address Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Target;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ListBox listBox_resultAddress;
        private System.Windows.Forms.ListBox listBox_resultData;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.CheckBox checkBox_scanCompleted;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

