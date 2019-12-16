using System.Windows.Forms.DataVisualization.Charting;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox_Ip2 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.checkBox_Connection1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Connection2 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Ip2
            // 
            this.textBox_Ip2.Location = new System.Drawing.Point(1164, 618);
            this.textBox_Ip2.Name = "textBox_Ip2";
            this.textBox_Ip2.Size = new System.Drawing.Size(175, 22);
            this.textBox_Ip2.TabIndex = 46;
            this.textBox_Ip2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1125, 599);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(1431, 618);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(57, 23);
            this.button_Connect.TabIndex = 50;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1143, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "IP";
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Location = new System.Drawing.Point(1164, 589);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(175, 22);
            this.textBox_Ip.TabIndex = 51;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(1345, 589);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(57, 22);
            this.textBox_Port.TabIndex = 53;
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Location = new System.Drawing.Point(1345, 618);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(57, 22);
            this.textBox_Port2.TabIndex = 54;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1185, 168);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(238, 45);
            this.trackBar3.TabIndex = 58;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1185, 117);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(238, 45);
            this.trackBar1.TabIndex = 59;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1185, 66);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(238, 45);
            this.trackBar2.TabIndex = 60;
            // 
            // checkBox_Connection1
            // 
            this.checkBox_Connection1.AutoSize = true;
            this.checkBox_Connection1.Location = new System.Drawing.Point(1410, 592);
            this.checkBox_Connection1.Name = "checkBox_Connection1";
            this.checkBox_Connection1.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Connection1.TabIndex = 61;
            this.checkBox_Connection1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Connection2
            // 
            this.checkBox_Connection2.AutoSize = true;
            this.checkBox_Connection2.Location = new System.Drawing.Point(1410, 623);
            this.checkBox_Connection2.Name = "checkBox_Connection2";
            this.checkBox_Connection2.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Connection2.TabIndex = 62;
            this.checkBox_Connection2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 652);
            this.Controls.Add(this.checkBox_Connection2);
            this.Controls.Add(this.checkBox_Connection1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.textBox_Port2);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Ip);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox_Ip2);
            this.Name = "Form1";
            this.Text = "CLV62x barcode scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Ip2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.CheckBox checkBox_Connection1;
        private System.Windows.Forms.CheckBox checkBox_Connection2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

