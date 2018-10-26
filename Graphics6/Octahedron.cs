using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics6
{
    class Octahedron : Primitive
    {
        // кол-во вершин = 6
        private List<XYZPoint> points = new List<XYZPoint>();

        // кол-во граней = 8
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

        public Octahedron(double size)
        {

        }

        public void Apply(Transform t)
        {
            foreach (var point in Points)
                point.Apply(t);
        }

        public void Draw(Graphics g, Transform projection, int width, int height)
        {
            if (Points.Count != 6) return;

            foreach (var Verge in Verges)
                Verge.Draw(g, projection, width, height);
        }
    }
}
