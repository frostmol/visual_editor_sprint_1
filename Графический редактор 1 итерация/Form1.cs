using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Графический_редактор_1_итерация
{
    public partial class Form1 : Form
    {
        Painter p;
        public Form1()
        {
            InitializeComponent();
            Graphics gr = pictureBox1.CreateGraphics();
            p = new Painter(gr);
        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Painter p = new Painter(gr);
            p.ClearForm();
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Painter p = new Painter(gr);
            p.DrawCircle(150, 50, 150, 50);
        }

        private void DrawSquare_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Painter p = new Painter(gr);
            p.DrawSquare(150, 50, 150, 50);
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Painter p = new Painter(gr);
            p.DrawLine(50, 50, 200, 200);
        }

        private void DrawGroup_Click(object sender, EventArgs e)
        {
            List<GrObject> grObjects = new List<GrObject>();
            PropList prL = new PropList();
            PropList prL2 = new PropList();
            prL.Add(new LineProps(Color.Black, 1));
            prL.Add(new FillProps(Color.Red));
            prL2.Add(new FillProps(Color.White));
            grObjects.Add(new Square(new Frame(25, 25, 325, 325), prL));
            grObjects.Add(new Circle(new Frame(100, 100, 250, 250), prL2));
            Group group = new Group(grObjects);
            group.Draw(p);

        }
    }
}
