using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minisoft1
{
	public partial class GameForm : Form
	{
		Settings settings;
		Block[] blocks;
		Block selected;
		bool clicked;
		Random rnd;
		
		public GameForm(Settings settings, Block[] blocks)
		{
			this.settings = settings;
			this.clicked = false;
			this.rnd = new Random();
			this.blocks = blocks;
			
			this.DoubleBuffered = true;
			InitializeComponent();
			
		}
		
		void GameFormPaint(object sender, PaintEventArgs e)
		{
			for( int i=0; i < this.settings.cols; i++)
			{
				for( int j=0; j < this.settings.rows; j++)
				{
					Pen blackPen = new Pen(Color.Black, 1);
					e.Graphics.DrawRectangle(blackPen, i*this.settings.cell_size, j*this.settings.cell_size, this.settings.cell_size, this.settings.cell_size);
				}
			}
			foreach(Block block in blocks)
			{
				block.Kresli(e.Graphics, 0);
			}			
		}

		void GameFormMouseDown(object sender, MouseEventArgs e)
		{
			foreach (Block block in blocks)
			{
				if (e.X < block.x+block.width && e.X > block.x)
				{
					if (e.Y < block.y+block.height && e.Y > block.y)
					{
						selected = block;
						clicked = true;
						break;
					}
				}
			}
		}
		
		void GameFormMouseUp(object sender, MouseEventArgs e)
		{
			clicked = false;
		}
		
		void GameFormMouseMove(object sender, MouseEventArgs e)
		{
			if(clicked) 
			{
				int xx = selected.x+selected.width;
				int yy = selected.x+selected.height;
				
				selected.x = e.X;
				selected.y = e.Y;
				Invalidate();
			}
		}
	}
}
