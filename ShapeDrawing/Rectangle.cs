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

        getString();
    }

    private void getString()
    {
        //Maakt een array waar SVGPolyline wat mee kan
        Point a, b, c, d;
        a = new Point(x, y);
        b = new Point(x + width, y);
        c = new Point(x + width, y + height);
        d = new Point(x, y + height);
        Point[] pts = { a, b, c, d };
        svgClass = new SVGPolyline(pts);
        SVGString = svgClass.createSVGString();
    }
}

