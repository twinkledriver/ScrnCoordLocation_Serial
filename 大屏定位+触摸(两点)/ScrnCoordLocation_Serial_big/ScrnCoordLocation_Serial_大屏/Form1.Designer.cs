namespace serialport
{
    partial class FormTestSerialPort
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestSerialPort));
            this.buttonOpenport = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboPortNme = new System.Windows.Forms.ComboBox();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.groupDataReceived = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.checkBoxAN = new System.Windows.Forms.CheckBox();
            this.checkBoxRHex = new System.Windows.Forms.CheckBox();
            this.labelPortNME = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.groupBoxDataSend = new System.Windows.Forms.GroupBox();
            this.lableSendCount = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.checkBoxSN = new System.Windows.Forms.CheckBox();
            this.checkBoxSHex = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupDataReceived.SuspendLayout();
            this.groupBoxDataSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenport
            // 
            this.buttonOpenport.Location = new System.Drawing.Point(361, 22);
            this.buttonOpenport.Name = "buttonOpenport";
            this.buttonOpenport.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenport.TabIndex = 0;
            this.buttonOpenport.Text = "打开串口";
            this.buttonOpenport.UseVisualStyleBackColor = true;
            this.buttonOpenport.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(6, 52);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(309, 219);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(361, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboPortNme
            // 
            this.comboPortNme.FormattingEnabled = true;
            this.comboPortNme.Location = new System.Drawing.Point(75, 25);
            this.comboPortNme.Name = "comboPortNme";
            this.comboPortNme.Size = new System.Drawing.Size(93, 20);
            this.comboPortNme.TabIndex = 4;
            this.comboPortNme.Click += new System.EventHandler(this.comboPortNme_Click);
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.AutoCompleteCustomSource.AddRange(new string[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBaudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBaudrate.FormatString = "N0";
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(233, 25);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(111, 20);
            this.comboBaudrate.TabIndex = 5;
            this.comboBaudrate.Text = "9600";
            // 
            // groupDataReceived
            // 
            this.groupDataReceived.Controls.Add(this.label4);
            this.groupDataReceived.Controls.Add(this.label3);
            this.groupDataReceived.Controls.Add(this.labelReceiveCount);
            this.groupDataReceived.Controls.Add(this.checkBoxAN);
            this.groupDataReceived.Controls.Add(this.checkBoxRHex);
            this.groupDataReceived.Controls.Add(this.ContentBox);
            this.groupDataReceived.Location = new System.Drawing.Point(12, 67);
            this.groupDataReceived.Name = "groupDataReceived";
            this.groupDataReceived.Size = new System.Drawing.Size(332, 264);
            this.groupDataReceived.TabIndex = 6;
            this.groupDataReceived.TabStop = false;
            this.groupDataReceived.Text = "收到的数据   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(136, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "y轴";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(102, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "x轴";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Location = new System.Drawing.Point(244, -1);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(71, 12);
            this.labelReceiveCount.TabIndex = 9;
            this.labelReceiveCount.Text = "接收计数：0";
            // 
            // checkBoxAN
            // 
            this.checkBoxAN.AutoSize = true;
            this.checkBoxAN.Checked = true;
            this.checkBoxAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAN.Location = new System.Drawing.Point(142, -2);
            this.checkBoxAN.Name = "checkBoxAN";
            this.checkBoxAN.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAN.TabIndex = 4;
            this.checkBoxAN.Text = "自动换行";
            this.checkBoxAN.UseVisualStyleBackColor = true;
            // 
            // checkBoxRHex
            // 
            this.checkBoxRHex.AutoSize = true;
            this.checkBoxRHex.Checked = true;
            this.checkBoxRHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRHex.Location = new System.Drawing.Point(77, -2);
            this.checkBoxRHex.Name = "checkBoxRHex";
            this.checkBoxRHex.Size = new System.Drawing.Size(66, 16);
            this.checkBoxRHex.TabIndex = 3;
            this.checkBoxRHex.Text = "Hex视图";
            this.checkBoxRHex.UseVisualStyleBackColor = true;
            // 
            // labelPortNME
            // 
            this.labelPortNME.AutoSize = true;
            this.labelPortNME.Location = new System.Drawing.Point(16, 28);
            this.labelPortNME.Name = "labelPortNME";
            this.labelPortNME.Size = new System.Drawing.Size(53, 12);
            this.labelPortNME.TabIndex = 7;
            this.labelPortNME.Text = "串口名称";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(186, 28);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(41, 12);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "波特率";
            // 
            // groupBoxDataSend
            // 
            this.groupBoxDataSend.Controls.Add(this.lableSendCount);
            this.groupBoxDataSend.Controls.Add(this.buttonSend);
            this.groupBoxDataSend.Controls.Add(this.SendBox);
            this.groupBoxDataSend.Controls.Add(this.checkBoxSN);
            this.groupBoxDataSend.Controls.Add(this.checkBoxSHex);
            this.groupBoxDataSend.Location = new System.Drawing.Point(12, 337);
            this.groupBoxDataSend.Name = "groupBoxDataSend";
            this.groupBoxDataSend.Size = new System.Drawing.Size(434, 70);
            this.groupBoxDataSend.TabIndex = 9;
            this.groupBoxDataSend.TabStop = false;
            this.groupBoxDataSend.Text = "发送数据   ";
            // 
            // lableSendCount
            // 
            this.lableSendCount.AutoSize = true;
            this.lableSendCount.Location = new System.Drawing.Point(323, 1);
            this.lableSendCount.Name = "lableSendCount";
            this.lableSendCount.Size = new System.Drawing.Size(71, 12);
            this.lableSendCount.TabIndex = 4;
            this.lableSendCount.Text = "发送计数：0";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(349, 29);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(6, 20);
            this.SendBox.Multiline = true;
            this.SendBox.Name = "SendBox";
            this.SendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendBox.Size = new System.Drawing.Size(326, 44);
            this.SendBox.TabIndex = 2;
            // 
            // checkBoxSN
            // 
            this.checkBoxSN.AutoSize = true;
            this.checkBoxSN.Location = new System.Drawing.Point(105, 0);
            this.checkBoxSN.Name = "checkBoxSN";
            this.checkBoxSN.Size = new System.Drawing.Size(48, 16);
            this.checkBoxSN.TabIndex = 1;
            this.checkBoxSN.Text = "换行";
            this.checkBoxSN.UseVisualStyleBackColor = true;
            // 
            // checkBoxSHex
            // 
            this.checkBoxSHex.AutoSize = true;
            this.checkBoxSHex.Location = new System.Drawing.Point(63, 0);
            this.checkBoxSHex.Name = "checkBoxSHex";
            this.checkBoxSHex.Size = new System.Drawing.Size(42, 16);
            this.checkBoxSHex.TabIndex = 0;
            this.checkBoxSHex.Text = "Hex";
            this.checkBoxSHex.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
        //    this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(361, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "鼠标定位";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "光标1-X坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "光标1-Y坐标";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "触摸测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "光标2-Y坐标";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "光标2-X坐标";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(361, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(361, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormTestSerialPort
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBoxDataSend);
            this.Controls.Add(this.labelBaudrate);
            this.Controls.Add(this.labelPortNME);
            this.Controls.Add(this.comboBaudrate);
            this.Controls.Add(this.comboPortNme);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOpenport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupDataReceived);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTestSerialPort";
            this.Text = "串口调试助手 V0.1a";
            this.Load += new System.EventHandler(this.FormTestSerialPort_Load);
            this.groupDataReceived.ResumeLayout(false);
            this.groupDataReceived.PerformLayout();
            this.groupBoxDataSend.ResumeLayout(false);
            this.groupBoxDataSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenport;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboPortNme;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.GroupBox groupDataReceived;
        private System.Windows.Forms.Label labelPortNME;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.CheckBox checkBoxAN;
        private System.Windows.Forms.CheckBox checkBoxRHex;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.GroupBox groupBoxDataSend;
        private System.Windows.Forms.CheckBox checkBoxSN;
        private System.Windows.Forms.CheckBox checkBoxSHex;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.Label lableSendCount;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
    }
}

