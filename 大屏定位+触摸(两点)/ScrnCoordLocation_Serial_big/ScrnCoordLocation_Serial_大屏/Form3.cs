using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Data.OleDb;
using System.Diagnostics;

namespace serialport
{
 

    public partial class Form3 : Form
    {
          private bool isDrawing =false;
          private Point startPoint, oldPoint, startPoint2, oldPoint2;

        private enum drawTools
        {
            Pen=0,Line,Ellipse,Rubber,None
        }

        private drawTools drawTool =drawTools.Pen;

        private Image theImage;
        private Graphics ig;

        private Color foreColor = Color.Black;
        private Color foreColor2 = Color.Blue;
        private Color backColor = Color.White;



        public Form3()
        {
            InitializeComponent();

        }

        public void Form3_MouseDown(object sender, MouseEventArgs e)
        {


            String aaX_str = this.textBox1.Text;
            String aaY_str = this.textBox2.Text;
            String bbX_str = this.textBox3.Text;
            String bbY_str = this.textBox4.Text;

            int bby_int = 0;
            int bbx_int = 0;

            if (bbX_str.Length != 0)
            {
                bbx_int = Convert.ToInt32(bbX_str, 10) - 10;
            }
            else
            {
                textBox3.Text = "0";
            }

            if (bbY_str.Length != 0)
            {
                bby_int = Convert.ToInt32(bbY_str, 10) - 10;
            }
            else
            {
                textBox4.Text = "0";
            }

            int aax_int = Convert.ToInt32(aaX_str, 10);
            int aay_int = Convert.ToInt32(aaY_str, 10) - 10;

   

           if(e.Button == MouseButtons.Left)
           {
            if((isDrawing=!isDrawing) ==true)
               {
                startPoint = new Point(aax_int,aay_int);
                oldPoint =new Point(aax_int,aay_int);

                startPoint2 = new Point(bbx_int, bby_int);
                oldPoint2 = new Point(bbx_int, bby_int);

               }
           }

         }


        public void Form3_MouseMove(object sender, MouseEventArgs e)
        {

            String aaX_str = this.textBox1.Text;
            String aaY_str = this.textBox2.Text;
            String bbX_str = this.textBox3.Text;
            String bbY_str = this.textBox4.Text;

            int bby_int =0;
            int bbx_int = 0;


            if (bbX_str.Length != 0)
            {
                bbx_int = Convert.ToInt32(bbX_str, 10) - 10;
            }
            else
            {
                textBox3.Text = "0";
            }

          

            if (bbY_str.Length != 0)
            {
                bby_int = Convert.ToInt32(bbY_str, 10) - 10;
            }
            else
            {
                textBox4.Text = "0";
            }


            int aax_int = Convert.ToInt32(aaX_str, 10);
            int aay_int = Convert.ToInt32(aaY_str, 10) - 10;
       
            



            Graphics g;
            g = this.CreateGraphics();

            if (isDrawing)
            {
                g.DrawLine(new Pen(ForeColor, 2), oldPoint, new Point(aax_int, aay_int));
                g.DrawLine(new Pen(ForeColor, 2), oldPoint2, new Point(bbx_int, bby_int));

                oldPoint.X = aax_int;
                oldPoint.Y = aay_int;


                oldPoint2.X = bbx_int;
                oldPoint2.Y = bby_int;
                
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (theImage != null)
            {
                g.Clear(Color.White);
                g.DrawImage(theImage, this.ClientRectangle);
            }
        }



    }
}

