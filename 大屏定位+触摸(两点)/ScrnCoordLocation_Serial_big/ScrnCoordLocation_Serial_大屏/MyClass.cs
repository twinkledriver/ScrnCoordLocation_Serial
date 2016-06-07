using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace 画图板
{
   //定义抽象基类Shape
    public abstract class Shape
    {
        //绘制图元方法（抽象方法）
        public abstract void Draw(Graphics g);
        public abstract void Write(BinaryWriter binaryWriter);
        public abstract void Read(BinaryReader binaryReader);

        public int _penWidth=10;
        public Color _penColor = Color.Red;
    }

    //定义直线类Line
    public class Line : Shape
    {
        //直线的起点和终点
        public Point _p1, _p2;
        //构造函数
        public Line()
        {

        }

        //绘制图元方法（重写抽象方法）
        public override void Draw(Graphics g)
        {
            //创建画笔对象
            Pen pen = new Pen(_penColor, _penWidth);
            //绘制直线
            g.DrawLine(pen, _p1, _p2);
        }

        public override void Write(BinaryWriter binaryWriter)
        {
            //写入线宽和颜色
            binaryWriter.Write(_penWidth);
            binaryWriter.Write(_penColor.ToArgb());
            //写入点的坐标
            binaryWriter.Write(_p1.X);
            binaryWriter.Write(_p1.Y);
            binaryWriter.Write(_p2.X);
            binaryWriter.Write(_p2.Y);
        }

        public override void Read(BinaryReader binaryReader)
        {
            //读出线宽颜色
            _penWidth = binaryReader.ReadInt32();
            _penColor =Color.FromArgb(binaryReader.ReadInt32());
            //读出点的坐标
            _p1.X = binaryReader.ReadInt32();
            _p1.Y = binaryReader.ReadInt32();
            _p2.X = binaryReader.ReadInt32();
            _p2.Y = binaryReader.ReadInt32();
        }
    }

    //定义矩形类rectangle
    public class Rectangle : Shape
    {
        public Point _p1, _p2;

        public Rectangle()
        {
        }

        public override void Draw(Graphics g)
        {
            //创建画笔对象
            Pen pen = new Pen(_penColor, _penWidth);
            Point leftTop = new Point();
            leftTop.X = (_p1.X <= _p2.X) ? _p1.X : _p2.X;
            leftTop.Y = (_p1.Y <= _p2.Y) ? _p1.Y : _p2.Y;

            g.DrawRectangle(pen, leftTop.X, leftTop.Y, Math.Abs(_p1.X - _p2.X), Math.Abs(_p1.Y - _p2.Y));
        }

        public override void Write(BinaryWriter binaryWriter)
        {
            //写入线宽和颜色
            binaryWriter.Write(_penWidth);
            binaryWriter.Write(_penColor.ToArgb());
            //写入点的坐标
            binaryWriter.Write(_p1.X);
            binaryWriter.Write(_p1.Y);
            binaryWriter.Write(_p2.X);
            binaryWriter.Write(_p2.Y);
        }

        public override void Read(BinaryReader binaryReader)
        {
            //读出线宽颜色
            _penWidth = binaryReader.ReadInt32();
            _penColor = Color.FromArgb(binaryReader.ReadInt32());
            //读出点的坐标
            _p1.X = binaryReader.ReadInt32();
            _p1.Y = binaryReader.ReadInt32();
            _p2.X = binaryReader.ReadInt32();
            _p2.Y = binaryReader.ReadInt32();
        }
    }

    //定义圆类Circle
    public class Circle : Shape
    {
        public Point _p1;
        public int r;

        public Circle()
        {
        }

        public override void Draw(Graphics g)
        {
            //创建画笔对象
            Pen pen = new Pen(_penColor, _penWidth);
            Point leftTop = new Point();
            leftTop.X = _p1.X-r; 
            leftTop.Y = _p1.Y-r;
            g.DrawLine(pen, _p1.X - 3, _p1.Y, _p1.X + 3, _p1.Y);
            g.DrawLine(pen, _p1.X, _p1.Y-3, _p1.X, _p1.Y+3);
            g.DrawEllipse(pen, leftTop.X, leftTop.Y, 2 * r, 2 * r);
        }

        public override void Write(BinaryWriter binaryWriter)
        {
            //写入线宽和颜色
            binaryWriter.Write(_penWidth);
            binaryWriter.Write(_penColor.ToArgb());
            //写入点的坐标
            binaryWriter.Write(_p1.X);
            binaryWriter.Write(_p1.Y);
            binaryWriter.Write(r);
            
        }

        public override void Read(BinaryReader binaryReader)
        {
            //读出线宽颜色
            _penWidth = binaryReader.ReadInt32();
            _penColor = Color.FromArgb(binaryReader.ReadInt32());
            //读出点的坐标
            _p1.X = binaryReader.ReadInt32();
            _p1.Y = binaryReader.ReadInt32();
            r = binaryReader.ReadInt32();
           
        }
    }

    //定义椭圆类Ellipse
    public class Ellipse : Shape
    {
        public Point _p1, _p2;

        public Ellipse()
        {
        }

        public override void Draw(Graphics g)
        {
            //创建画笔对象
            Pen pen = new Pen(_penColor, _penWidth);
            Point leftTop = new Point();
            leftTop.X = (_p1.X <= _p2.X) ? _p1.X : _p2.X;
            leftTop.Y = (_p1.Y <= _p2.Y) ? _p1.Y : _p2.Y;

            g.DrawEllipse(pen, leftTop.X, leftTop.Y, Math.Abs(_p1.X - _p2.X), Math.Abs(_p1.Y - _p2.Y));
        }

        public override void Write(BinaryWriter binaryWriter)
        {
            //写入线宽和颜色
            binaryWriter.Write(_penWidth);
            binaryWriter.Write(_penColor.ToArgb());
            //写入点的坐标
            binaryWriter.Write(_p1.X);
            binaryWriter.Write(_p1.Y);
            binaryWriter.Write(_p2.X);
            binaryWriter.Write(_p2.Y);
        }

        public override void Read(BinaryReader binaryReader)
        {
            //读出线宽颜色
            _penWidth = binaryReader.ReadInt32();
            _penColor = Color.FromArgb(binaryReader.ReadInt32());
            //读出点的坐标
            _p1.X = binaryReader.ReadInt32();
            _p1.Y = binaryReader.ReadInt32();
            _p2.X = binaryReader.ReadInt32();
            _p2.Y = binaryReader.ReadInt32();
        }
    }
}
