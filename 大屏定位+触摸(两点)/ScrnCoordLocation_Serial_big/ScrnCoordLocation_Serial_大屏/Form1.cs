using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using WindowsHook;                                                     

namespace serialport
{
    public partial class FormTestSerialPort : Form
    {
        private SerialPort comm = new SerialPort();
        private StringBuilder builder = new StringBuilder();
        private long receive_count = 0;
        private long send_count = 0;



        
        public FormTestSerialPort()
        {
            InitializeComponent();
        }

        private void FormTestSerialPort_Load(object sender, EventArgs e)
        {
            //获取串口列表
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            if(ports.Length!=0)
            comboPortNme.Text = ports[0];
            comboBaudrate.Text = "115200";
            comboPortNme.Items.AddRange(ports);
            comboPortNme.SelectedIndex = comboPortNme.Items.Count > 0 ? 0 : -1;
            comboBaudrate.SelectedIndex = comboBaudrate.Items.IndexOf("115200");
            //初始化SerialPort对象
            comm.NewLine = "/r/n";
            comm.RtsEnable = true;
            comm.DataReceived += comm_DataReceived;
            this.buttonOpenport.Text = comm.IsOpen ? "关闭端口" : "打开端口";
            this.buttonSend.Enabled = comm.IsOpen;
      
        }
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //读取缓冲区数据
          
            int n = comm.BytesToRead;
            byte[] buf = new byte[n];
            receive_count += n;
            comm.Read(buf, 0, n);
            builder.Remove(0, builder.Length);
            //同步UI
            this.BeginInvoke((EventHandler)(delegate
            {
                
                //处理16进制显示
                if (checkBoxRHex.Checked)
                {
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }
                //处理ASCII显示
                else
                {
                    builder.Append(Encoding.ASCII.GetString(buf));
                }

                if (checkBox1.Checked)
                {
                   
                        MoveCursor();
                }
              

                //将接收到的数据追加到文本框末端，并将文本框滚动到末端
                this.ContentBox.AppendText(builder.ToString());

                //修改接收计数
                this.labelReceiveCount.Text = "接收计数" + receive_count.ToString();
               
               
               
            }));
            comm.Write(new byte[] { 0xFF, 0xFF, 0x04, 0x01, 0x01, 0x00, 0x00, 0xF9 }, 0, 8);

        }

       

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            
            if (comboPortNme.Text.Length == 0)
            {
                MessageBox.Show("请输入正确的串口编号！");
                return;
            }
            if (comm.IsOpen)
            {
                comm.Close();
            }
            else
            {
                comm.PortName = comboPortNme.Text;
                try
                {
                    comm.BaudRate = int.Parse(comboBaudrate.Text);
                }
                catch (Exception )
                {
                    MessageBox.Show("波特率输入不正确，将使用默认波特率："+comm.BaudRate+"!");
                    comboBaudrate.Text = comm.BaudRate.ToString();
                }
                try
                {
                    comm.Open();
                }
                catch (Exception ex)
                { 
                    //处理并返回异常
                    comm = new SerialPort();
                    MessageBox.Show(ex.Message);
                }
            }
            this.buttonOpenport.Text =comm.IsOpen? "关闭端口":"打开端口";
            this.buttonSend.Enabled = comm.IsOpen;
        }
        //动态获取自动换行复选框状态
        private void ContentBox_TextChanged(object sender, EventArgs e)
        {
            this.ContentBox.WordWrap = checkBoxAN.Checked;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //记录发送字节数
            int n = 0;
            //16进制发送
            if (checkBoxSHex.Checked)
            {
                MatchCollection mc = Regex.Matches(SendBox.Text, @"(?i)[/da-f]{2}");
                List<byte> buf = new List<byte>();
                foreach (Match m in mc)
                {
                    buf.Add(byte.Parse(m.Value));
                }
                //转换为数组之后发送
                comm.Write(buf.ToArray(), 0, buf.Count);
                //记录发送的字节数
                n = buf.Count;

            }
            else
            {
                if(checkBoxSN.Checked)
                {
                    comm.WriteLine(SendBox.Text);
                    n=SendBox.Text.Length+2;
                }
                else
                {
                    comm.Write(SendBox.Text);
                    n=SendBox.Text.Length;
                }
            }
            send_count+=n;
            lableSendCount.Text="发送计数："+send_count.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //复位接收和发送字节数并更新界面
            this.ContentBox.Clear();
            send_count = receive_count = 0;
            labelReceiveCount.Text = "接收计数：0";
            lableSendCount.Text = "发送计数：0";
           
        }


        private void comboPortNme_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboPortNme.Items.Clear();
            comboPortNme.Items.AddRange(ports);
        }

      

        private void MoveCursor()
        {
            String aa = builder.ToString();
            aa = aa.Replace(" ", "");
            String aax_Hex;
            String aay_Hex;
            String aa_state_Hex;

            try
            {
                aax_Hex = aa.Substring(aa.Length - 22, 4);             
                aay_Hex = aa.Substring(aa.Length - 18, 4);             
                aa_state_Hex = aa.Substring(aa.Length - 24, 2);      
              
            }
            catch
            {
                return;                                             
            }
           

            int aax_decimal = Convert.ToInt32(aax_Hex, 16);         
            int aay_decimal = Convert.ToInt32(aay_Hex, 16);
          


            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(aax_decimal, aay_decimal);         

            if (aa_state_Hex.Equals("01"))
            {
               SendMouseEvent.LeftDown();
                     
            }
            else if (aa_state_Hex.Equals("04"))
            {
               SendMouseEvent.LeftUp();
            }


            String bbx_Hex;
            String bby_Hex;
            String bb_state_Hex;


            try
            {
                bbx_Hex = aa.Substring(aa.Length - 10, 4);
                bby_Hex = aa.Substring(aa.Length - 6, 4);
                bb_state_Hex = aa.Substring(aa.Length - 12, 2);

            }
            catch
            {
                return;
            }


            int bbx_decimal = Convert.ToInt32(bbx_Hex, 16);
            int bby_decimal = Convert.ToInt32(bby_Hex, 16);

        }


   
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            String aa = builder.ToString();
            aa = aa.Replace(" ", "");  
            String bbx_Hex;
            String bby_Hex;
            String bb_state_Hex;

            textBox1.Text = System.Windows.Forms.Control.MousePosition.X.ToString();
            textBox2.Text = System.Windows.Forms.Control.MousePosition.Y.ToString();

        

            frm3.textBox1.Text = this.textBox1.Text;
            frm3.textBox2.Text = this.textBox2.Text;
        
       


            try
            {
                bbx_Hex = aa.Substring(aa.Length - 10, 4);
                bby_Hex = aa.Substring(aa.Length - 6, 4);
                bb_state_Hex = aa.Substring(aa.Length - 12, 2);

                textBox3.Text = bbx_Hex;
                textBox4.Text = bby_Hex;


                frm3.textBox3.Text = this.textBox3.Text;
                frm3.textBox4.Text = this.textBox4.Text;

            }
            catch
            {
                return;
            }

         

        }

                
        Form2 b = new Form2();

        Form3 frm3 = new Form3();

       private void button1_Click(object sender, EventArgs e) 
       {
           b.ShowDialog();
       }




       private void button3_Click(object sender, EventArgs e)
       {

           frm3.ShowDialog();
   
       }

        
        
              
        
                

              







    }
                   
                

           
               

            
                  


   

      

}
