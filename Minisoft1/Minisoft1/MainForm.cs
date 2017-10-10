using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Minisoft1
{
	public partial class MainForm : Form
	{		
		SaveLoadManager sm = new SaveLoadManager();
		Settings settings;
		Block[] blocks;
		Random rnd;
		const int INDENT = 200;
		
		List<int> list = new List<int>();
		int rows, cols, cell_size, blockCount;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//

			InitializeComponent();
			DoubleBuffered = true;
			
			settings = sm.load();
			rnd = new Random();
			blocks = new Block[settings.blockCount];					
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
		    Graphics g = e.Graphics;
			for( int i=0; i < settings.cols; i++)
			{
				for( int j=0; j < settings.rows; j++)
				{			
					Pen blackPen = new Pen(Color.Black, 1);
					g.DrawRectangle(blackPen, 200+(i*settings.cell_size),(j*settings.cell_size),settings.cell_size,settings.cell_size);
				}
			}
			
			foreach(Block block in blocks)
			{
				block.Kresli(e.Graphics, INDENT);
			}	
			
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			
			if (settings != null) 
			{
				NumberOfRows.Value = settings.rows;
				NumberOfCols.Value = settings.cols;
				CellSize.Value = settings.cell_size;
				CountOfBlocks.Value = settings.blockCount;
			}
			
			for(int i=0; i < this.settings.blockCount; i++)
			{
				Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
				int r = rnd.Next(1,5);
				int c = rnd.Next(1,5);
				int x = this.settings.rows * this.settings.cell_size;
				int y = i*this.settings.cell_size;
				int width = this.settings.cell_size*r;
				int height = this.settings.cell_size*c;
				Block block = new Block(x+20, y, width, height, r, c, color);
				blocks[i] = block;
			}			
		}		
		
		void ButtonPlayClick(object sender, EventArgs e)
		{
			Settings settings = new Settings 
			{
				rows = Convert.ToInt32(NumberOfRows.Value), 
				cols = Convert.ToInt32(NumberOfCols.Value), 
				cell_size = Convert.ToInt32(CellSize.Value), 
				blockCount = Convert.ToInt32(CountOfBlocks.Value)
			};
			// save to file
			sm.save(settings);
			// hide main and show gameform
			GameForm gf = new GameForm(settings, blocks);
			this.Hide();
			gf.Show();
			
			
		}
        private void NumberOfRowsValueChanged(object sender, System.EventArgs e)
        {
        	if (Convert.ToInt32(NumberOfRows.Value) < rows)
            {
                MessageBox.Show("Down");
            }
        	else if(Convert.ToInt32(NumberOfRows.Value) > rows)
            {
                MessageBox.Show("Up");
            }

            rows = Convert.ToInt32(NumberOfRows.Value);
            this.settings.rows = rows;

        }
        
//		void NumberOfRowsValueChanged(object sender, EventArgs e)
//		{
//			rows = Convert.ToInt32(NumberOfRows.Value);
//			MessageBox.Show(Convert.ToString(rows) + " " + Convert.ToString(this.settings.rows));
//		}


		void NumberOfColsValueChanged(object sender, EventArgs e)
		{
			cols = Convert.ToInt32(NumberOfCols.Value);
		}
		void SquareSizeValueChanged(object sender, EventArgs e)
		{
			cell_size = Convert.ToInt32(CellSize.Value);
		}
		void NumberOfRectaglesValueChanged(object sender, EventArgs e)
		{
			blockCount = Convert.ToInt32(CountOfBlocks.Value);
		}

	
	}
}
