using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графический_редактор_1_итерация
{
    public class Painter
    {
        public Graphics gr;
        // Обводка
        private Pen pen = new Pen(Color.Black, 1);
        // Заливка
        private SolidBrush brush = new SolidBrush(Color.Red);

        public Color PenColor { set => pen.Color = value; }
        public Color BrushColor { set => brush.Color = value; }
        public int PenWidth { set => pen.Width = value; }
        public Painter(Graphics gr1)
        {
            gr = gr1;
        }

        public void DrawSquare(int x1, int x2, int y1, int y2)
        {
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            gr.FillRectangle(brush, x, y, width, height);
            gr.DrawRectangle(pen, x, y, width, height);
        }

        public void DrawLine(int x1, int x2, int y1, int y2)
        {
            gr.DrawLine(pen, x1, x2, y1, y2);
        }

        public void DrawCircle(int x1, int x2, int y1, int y2)
        {
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            gr.FillEllipse(brush, x, y, width, height);
            gr.DrawEllipse(pen, x, y, width, height);
        }

        public void ClearForm()
        {
            gr.Clear(Color.White);
        }
    }
}
