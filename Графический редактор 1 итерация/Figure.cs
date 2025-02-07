using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор_1_итерация
{
    public abstract class Figure: GrObject
    {
        public PropList proplist;

        public Figure(PropList proplist, Frame frame): base(frame)
        {
            this.proplist = proplist;
        }

        public override void Draw(Painter p)
        {
            proplist.Apply(p);
            DrawGeometry(p);
        }
        public abstract void DrawGeometry(Painter p);
    }
    public class Line: Figure
    {
        public Line(Frame frame, PropList proplist): base(proplist, frame)
        {

        }
        public override void DrawGeometry(Painter p)
        {
            p.DrawLine(frame.x1, frame.x2, frame.y1, frame.y2);
        }
    }

    public class Square : Figure
    {
        public Square(Frame frame, PropList proplist): base(proplist, frame)
        {

        }

        public override void DrawGeometry(Painter p)
        {
            p.DrawSquare(frame.x1, frame.x2, frame.y1, frame.y2);
        }
    }
    public class Circle : Figure
    {
        public Circle(Frame frame, PropList proplist) : base(proplist, frame)
        {

        }

        public override void DrawGeometry(Painter p)
        {
            p.DrawCircle(frame.x1, frame.x2, frame.y1, frame.y2);
        }
    }
}
