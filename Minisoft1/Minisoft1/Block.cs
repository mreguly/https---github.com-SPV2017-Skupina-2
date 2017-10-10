using System;
using System.Drawing;

namespace Minisoft1
{
	public class Block
	{
		public int x, y, width, height, r, c;
		public Color color; 
		
		public Block(int x, int y, int width, int height, int r, int c,Color color)
		{
			this.x = x;
			this.y = y;
			this.r = r;
			this.c = c;
			this.color = color;
			this.width = width;
			this.height = height;
		}
		public void Kresli(Graphics g, int indent)
		{
			SolidBrush brush = new SolidBrush(this.color);
			g.FillRectangle(brush, new Rectangle(indent+this.x, this.y, this.width, this.height));
		}
	}
}
