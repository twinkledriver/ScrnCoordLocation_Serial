using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace serialport
{
    public abstract class Shape
    {
        //绘制图元方法（抽象方法）
        public abstract void Draw(Graphics g);
        public abstract void Write(BinaryWriter binaryWriter);
        public abstract void Read(BinaryReader binaryReader);

        public int _penWidth = 10;
        public Color _penColor = Color.Red;
    }

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
            _penColor = Color.FromArgb(binaryReader.ReadInt32());
            //读出点的坐标
            _p1.X = binaryReader.ReadInt32();
            _p1.Y = binaryReader.ReadInt32();
            _p2.X = binaryReader.ReadInt32();
            _p2.Y = binaryReader.ReadInt32();
        }
    }


}
