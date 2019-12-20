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
            this.button_scan = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.trackBar_Velocity = new System.Windows.Forms.TrackBar();
            this.trackBar_Final = new System.Windows.Forms.TrackBar();
            this.trackBar_Inital = new System.Windows.Forms.TrackBar();
            this.checkBox_Connection1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Connection2 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_clrErr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Velocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Inital)).BeginInit();
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
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(1431, 195);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(75, 23);
            this.button_scan.TabIndex = 49;
            this.button_scan.Text = "scan";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_Scan_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(1431, 618);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(77, 23);
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
            // trackBar_Velocity
            // 
            this.trackBar_Velocity.Location = new System.Drawing.Point(1270, 144);
            this.trackBar_Velocity.Maximum = 50;
            this.trackBar_Velocity.Minimum = 10;
            this.trackBar_Velocity.Name = "trackBar_Velocity";
            this.trackBar_Velocity.Size = new System.Drawing.Size(238, 45);
            this.trackBar_Velocity.TabIndex = 58;
            this.trackBar_Velocity.Value = 50;
            // 
            // trackBar_Final
            // 
            this.trackBar_Final.Location = new System.Drawing.Point(1270, 93);
            this.trackBar_Final.Maximum = 230;
            this.trackBar_Final.Name = "trackBar_Final";
            this.trackBar_Final.Size = new System.Drawing.Size(238, 45);
            this.trackBar_Final.TabIndex = 59;
            // 
            // trackBar_Inital
            // 
            this.trackBar_Inital.Location = new System.Drawing.Point(1270, 42);
            this.trackBar_Inital.Maximum = 230;
            this.trackBar_Inital.Name = "trackBar_Inital";
            this.trackBar_Inital.Size = new System.Drawing.Size(238, 45);
            this.trackBar_Inital.TabIndex = 60;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1167, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "Inital angle[deg]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1168, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "Final angle[deg]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1149, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "Angular velocity[deg/s]";
            // 
            // button_clrErr
            // 
            this.button_clrErr.Location = new System.Drawing.Point(1431, 587);
            this.button_clrErr.Name = "button_clrErr";
            this.button_clrErr.Size = new System.Drawing.Size(75, 23);
            this.button_clrErr.TabIndex = 66;
            this.button_clrErr.Text = "Clear error";
            this.button_clrErr.UseVisualStyleBackColor = true;
            this.button_clrErr.Click += new System.EventHandler(this.button_clrErr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 652);
            this.Controls.Add(this.button_clrErr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_Connection2);
            this.Controls.Add(this.checkBox_Connection1);
            this.Controls.Add(this.trackBar_Inital);
            this.Controls.Add(this.trackBar_Final);
            this.Controls.Add(this.trackBar_Velocity);
            this.Controls.Add(this.textBox_Port2);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Ip);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox_Ip2);
            this.Name = "Form1";
            this.Text = "CLV62x barcode scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Velocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Inital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Ip2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TrackBar trackBar_Velocity;
        private System.Windows.Forms.TrackBar trackBar_Final;
        private System.Windows.Forms.TrackBar trackBar_Inital;
        private System.Windows.Forms.CheckBox checkBox_Connection1;
        private System.Windows.Forms.CheckBox checkBox_Connection2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clrErr;
    }
}

