using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;
    public string SVGString

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Draw(Graphics Canvas)
    {
		Pen pen = new Pen(Color.Black);
		Canvas.DrawLine(pen,x,y,x + width,y);
		Canvas.DrawLine(pen,x+width,y,x+width,y+height);
		Canvas.DrawLine(pen,x+width,y+height,x,y+height);
		Canvas.DrawLine(pen,x,y+height,x,y);
        Point a, b, c, d;
        a = new Point(x, y);
        b = new Point(x, y+width);
        c = new Point(x + height, y + width);
        d = new Point(x + height, y);
        Point[] pts = {a,b,c,d};
        svgClass = new SVGPolyline(pts);
        SVGString = svgClass.createSVGString();
    }
}

