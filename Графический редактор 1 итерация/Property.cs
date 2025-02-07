using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор_1_итерация
{
    public abstract class Property
    {
        abstract public void Apply(Painter p);
        abstract public Property Clone();
    }

    public class PropList
    {
        private List<Property> properties;
        public PropList()
        {
            properties = new List<Property>();
        }

        public void Apply(Painter p)
        {
            foreach (Property prop in properties)
            {
                prop.Apply(p);
            }
        }

        public void Add(Property prop)
        {
            properties.Add(prop);
        }

        public PropList Clone()
        {
            PropList clone = new PropList();
            for (int i = 0; i < properties.Count; i++)
            {
                clone.properties.Add(properties[i].Clone());
            }
            return clone;
        }
        public int Count { get { return properties.Count; } }
        public Property this[int i] { get { return properties[i]; } }
    }

    public class LineProps : Property
    {
        public Color color { get => color2; set => color2 = value; }
        private Color color2 = Color.Black;
        public int width { get => width2; set => width2 = value; }
        public int width2 = 1;
        public LineProps(Color color, int width)
        {
            color2 = color;
            width2 = width;
        }
        public override void Apply(Painter p)
        {
            p.PenColor = color2;
            p.PenWidth = width2;
        }
        public override Property Clone()
        {
            return new LineProps(color, width);
        }
    }

    public class FillProps : Property
    {
        private Color fillColor = Color.Transparent;
        public Color color { get => fillColor; set => fillColor = value; }
        public FillProps(Color fillColor)
        {
            this.fillColor = fillColor;
        }
        public override void Apply(Painter p)
        {
            p.BrushColor = fillColor;
        }
        public override Property Clone()
        {
            return new FillProps(fillColor);
        }
    }
}
