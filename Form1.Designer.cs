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
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.listBox_resultAddress = new System.Windows.Forms.ListBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.checkBox_scanCompleted = new System.Windows.Forms.CheckBox();
            this.textBox_addressCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_addressSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Contains = new System.Windows.Forms.CheckBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Receive = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target";
            // 
            // textBox_Target
            // 
            this.textBox_Target.HideSelection = false;
            this.textBox_Target.Location = new System.Drawing.Point(19, 28);
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.Size = new System.Drawing.Size(100, 22);
            this.textBox_Target.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(1022, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 12);
            this.label23.TabIndex = 40;
            this.label23.Text = "Connection:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(1087, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 41;
            this.label24.Text = "未连接";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(1165, 25);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(175, 22);
            this.textBox_IP.TabIndex = 46;
            this.textBox_IP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_IP_KeyDown);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1144, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 12);
            this.label25.TabIndex = 47;
            this.label25.Text = "IP:";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(19, 56);
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
            this.listBox_resultAddress.Size = new System.Drawing.Size(1354, 508);
            this.listBox_resultAddress.TabIndex = 49;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(19, 105);
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
            this.checkBox_scanCompleted.Location = new System.Drawing.Point(265, 30);
            this.checkBox_scanCompleted.Name = "checkBox_scanCompleted";
            this.checkBox_scanCompleted.Size = new System.Drawing.Size(97, 16);
            this.checkBox_scanCompleted.TabIndex = 52;
            this.checkBox_scanCompleted.Text = "Scan completed";
            this.checkBox_scanCompleted.UseVisualStyleBackColor = true;
            // 
            // textBox_addressCount
            // 
            this.textBox_addressCount.Enabled = false;
            this.textBox_addressCount.HideSelection = false;
            this.textBox_addressCount.Location = new System.Drawing.Point(128, 28);
            this.textBox_addressCount.Name = "textBox_addressCount";
            this.textBox_addressCount.Size = new System.Drawing.Size(51, 22);
            this.textBox_addressCount.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address Matched";
            // 
            // textBox_addressSize
            // 
            this.textBox_addressSize.Enabled = false;
            this.textBox_addressSize.HideSelection = false;
            this.textBox_addressSize.Location = new System.Drawing.Point(208, 28);
            this.textBox_addressSize.Name = "textBox_addressSize";
            this.textBox_addressSize.Size = new System.Drawing.Size(51, 22);
            this.textBox_addressSize.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 57;
            this.label4.Text = "Flags";
            // 
            // checkBox_Contains
            // 
            this.checkBox_Contains.AutoSize = true;
            this.checkBox_Contains.Location = new System.Drawing.Point(19, 178);
            this.checkBox_Contains.Name = "checkBox_Contains";
            this.checkBox_Contains.Size = new System.Drawing.Size(65, 16);
            this.checkBox_Contains.TabIndex = 58;
            this.checkBox_Contains.Text = "Contains";
            this.checkBox_Contains.UseVisualStyleBackColor = true;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(1409, 25);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(66, 22);
            this.button_Connect.TabIndex = 59;
            this.button_Connect.Text = "connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(1346, 25);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(57, 22);
            this.textBox_Port.TabIndex = 60;
            // 
            // textBox_Send
            // 
            this.textBox_Send.HideSelection = false;
            this.textBox_Send.Location = new System.Drawing.Point(53, 796);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(1429, 22);
            this.textBox_Send.TabIndex = 61;
            this.textBox_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Send_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 799);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 62;
            this.label5.Text = "Send :";
            // 
            // listBox_Receive
            // 
            this.listBox_Receive.FormattingEnabled = true;
            this.listBox_Receive.ItemHeight = 12;
            this.listBox_Receive.Location = new System.Drawing.Point(53, 579);
            this.listBox_Receive.Name = "listBox_Receive";
            this.listBox_Receive.Size = new System.Drawing.Size(1429, 208);
            this.listBox_Receive.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 830);
            this.Controls.Add(this.listBox_Receive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Send);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.checkBox_Contains);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_addressSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_addressCount);
            this.Controls.Add(this.checkBox_scanCompleted);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.listBox_resultAddress);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox_IP);
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
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ListBox listBox_resultAddress;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.CheckBox checkBox_scanCompleted;
        private System.Windows.Forms.TextBox textBox_addressCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_addressSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Contains;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Receive;
    }
}

