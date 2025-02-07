using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор_1_итерация
{
    public class Group : GrObject
    {
        private List<GrObject> objects;
        public Group(List<GrObject> objects2) : base(null)
        {
            objects = new List<GrObject>();
            GrObject[] temp = new GrObject[objects2.Count];
            objects2.CopyTo(temp, 0);
            for (int i = 0; i < temp.Length; i++)
            {
                objects.Add(temp[i]);
            }
        }

        public Frame CreateFrame()
        {
            int minX = objects.Min(obj => obj.frame.x1);
            int minY = objects.Min(obj => obj.frame.y1);
            int maxX = objects.Max(obj => obj.frame.x2);
            int maxY = objects.Max(obj => obj.frame.y2);
            return new Frame(minX, minY, maxX, maxY);
        }

        public override void Draw(Painter p2)
        {
            Frame groupFrame = CreateFrame();
            foreach (GrObject obj in objects)
            {
                obj.Draw(p2);
            }
        }
    }

}
