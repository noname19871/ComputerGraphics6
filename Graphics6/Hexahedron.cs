using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics6
{
    class Hexahedron : Primitive
    {
        // кол-во вершин = 8
        private List<XYZPoint> points = new List<XYZPoint>();

        // кол-во граней = 6
        private List<Verge> verges = new List<Verge>();

        public List<XYZPoint> Points { get { return points; } }
        public List<Verge> Verges { get { return verges; } }

        public XYZPoint Center
        {
            get
            {
                XYZPoint p = new XYZPoint(0, 0, 0);
                return p;
            }
        }

        public Hexahedron(double size)
        {

        }

        public void Apply(Transform t)
        {
            foreach (var point in Points)
                point.Apply(t);
        }

        public void Draw(Graphics g, Transform projection, int width, int height)
        {
            if (Points.Count != 8) return;

            foreach (var Verge in Verges)
                Verge.Draw(g, projection, width, height);
        }
    }
}
