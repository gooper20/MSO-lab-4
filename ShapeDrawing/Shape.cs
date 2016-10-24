using System;
using System.Drawing;

    public abstract class Shape
    {
        protected SVGStringCreator svgClass;
        public string SVGString;

        public Shape()
        {
        }

        public abstract void Draw(Graphics Canvas);

    }