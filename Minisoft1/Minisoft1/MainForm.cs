using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Minisoft1
{
	public partial class MainForm : Form
	{		
		SaveLoadManager sm;
		Settings settings;
		Random rnd;
		GameForm gameForm;
		
		public MainForm()
		{
			InitializeComponent();
			DoubleBuffered = true;
			
			sm = new SaveLoadManager();
			settings = sm.load();
			gameForm = new GameForm(settings, this);
			rnd = new Random();			
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
		    Graphics g = e.Graphics;
            // draw image	
            //Pen blackPen = new Pen(Color.Black, 1);
            //e.Graphics.DrawRectangle(blackPen, 200,25,400,300);
            Image main_image = Image.FromFile("main_picture.png");
            e.Graphics.DrawImage(main_image, 200, 25, 400, 300);

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
                

		}
		
		void ButtonPlayClick(object sender, EventArgs e)
		{
            settings = new Settings
            {
                rows = Convert.ToInt32(NumberOfRows.Value),
                cols = Convert.ToInt32(NumberOfCols.Value),
                cell_size = Convert.ToInt32(CellSize.Value),
                blockCount = Convert.ToInt32(CountOfBlocks.Value)
			};
			sm.save(settings);
			this.Hide();
			gameForm.Show();			
		}

        private void NumberOfRows_ValueChanged(object sender, EventArgs e)
        {
            this.settings.rows = Convert.ToInt32(NumberOfRows.Value);
        }

        private void NumberOfCols_ValueChanged(object sender, EventArgs e)
        {
            this.settings.cols = Convert.ToInt32(NumberOfCols.Value);
        }

        private void CellSize_ValueChanged(object sender, EventArgs e)
        {
            this.settings.cell_size = Convert.ToInt32(CellSize.Value);
        }

        private void CountOfBlocks_ValueChanged(object sender, EventArgs e)
        {
            this.settings.blockCount = Convert.ToInt32(CountOfBlocks.Value);
        }
    }
}
