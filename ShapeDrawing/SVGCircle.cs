using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class SVGCircle : SVGStringCreator
    {
        int R, X, Y;
        public SVGCircle(int r, int x, int y)
        {
            R = r;
            X = x;
            Y = y;
        }
        public override string createSVGString()
        {
            string value = "<circle ";
            int r = R/2;
            int cx = X + r;
            int cy = Y + r;
            value += "cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\"";
            value += "stroke-width=\"1\" fill=\"none\" stroke=\"black\" />";
            return value;
        }
    }
