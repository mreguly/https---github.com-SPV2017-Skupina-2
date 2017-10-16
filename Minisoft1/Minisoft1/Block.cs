using System;
using System.Drawing;

namespace Minisoft1
{
    public class Block
    {
        public int id, x, y, startX, startY, width, height;
        public Color color;

        public Block(int id, int x, int y, int width, int height, Color color)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.startX = x;
            this.startY = y;
            this.color = color;
            this.width = width;
            this.height = height;
        }

        public void Kresli(Graphics g)
        {
            SolidBrush brush = new SolidBrush(this.color);
            g.FillRectangle(brush, new Rectangle(this.x, this.y, this.width, this.height));
        }
    }
}
