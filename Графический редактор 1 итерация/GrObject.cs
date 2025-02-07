using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор_1_итерация
{
    public class GrObject
    {
        public Frame frame;
        public GrObject(Frame frame)
        {
            this.frame = frame;
        }
        public virtual void Draw(Painter p)
        {

        }
    }

}
