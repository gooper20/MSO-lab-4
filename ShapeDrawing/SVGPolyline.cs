using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class SVGPolyline : SVGStringCreator
    {
        Point[] points;

        public SVGPolyline(Point[] p)
        {
            points = p;
        }

        public override string createSVGString()
        {
            string value = "<polyline points=\"";
            for (int i = 0; i < points.Count(); i++)
            {
                value += points[i].X + "," + points[i].Y + " ";
            }
            value += points[0].X + "," + points[0].Y + "\"";
            value += "style=\"fill:none;stroke:black;stroke-width:1\" />";
            return value;
        }
    }
}
