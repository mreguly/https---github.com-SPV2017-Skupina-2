using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Minisoft1
{
	public partial class GameForm : Form
	{
		Settings settings;
		Block[] blocks;
		Block selected;
		bool clicked;
		Random rnd;
        int[,] playground;
        int up = 0;
        MainForm mainForm;


        const int INDENT_X = 0;
		const int INDENT_Y = 0;

        int deltaX, deltaY;
		
		public GameForm(Settings settings, MainForm mainForm)
		{	
			DoubleBuffered = true;
			InitializeComponent();
			
			this.settings = settings;
			this.clicked = false;
			this.rnd = new Random();
            this.playground = new int[this.settings.rows, this.settings.cols];
            this.mainForm = mainForm;
				
		}

        public struct obdlznik
        {
            public int x, y;
        }

        public obdlznik[] rozdel(int pocet_casti, obdlznik[] obdl)
        {        // funkcia
            bool spravne = false;
            int r, s, t;                                                //nahodne premenne
            Random rnd = new Random();                                //vytvorenie random generatoru 
            for (int i = 0; i < pocet_casti - 1; i++)
            {                   //ideme delit v kazdej iteracii cyklu 1 nahodnu cast na 2 mensie
                while (!spravne)
                {                                        //nie kazdu malu cast vieme rozdelit(taku co ma velkost jedna uz nerozdelime)
                                                            //preto ideme dovtedy vo while cykle, az kym nerozdelime na 2 spravne casti o velkosti apson 1
                    r = rnd.Next(i + 1);                            //nahodne vyberieme, ze ktory utvar ideme delit
                    s = rnd.Next(2);                              //nahodne vyberieme, ci ho rozrezeme na vysku alebo na sirku
                    if (s == 0)
                    {                                  //ak 0, tak ideme rezat na sirku
                        if (obdl[r].x > 1)
                        {                          //ak mozme rezat, teda ak ma sirku aspon 2, inak znova prejde while cyklus a znovu sa vygeneruju nahodne premenne
                            t = rnd.Next(1, obdl[r].x);               //nahodne miesto kde ho rozdelime
                            obdl[i + 1].x = obdl[r].x - t;              //vypocitame a priradime sirku noveho
                            obdl[i + 1].y = obdl[r].y;               //priradime rovnaku vysku aku mal stary aj novemu
                            obdl[r].x = t;                            //stary skratime o velkost noveho
                            spravne = true;                           //nastalo spravne rozdelenie a tym padom uz bool spravne bude true, cize skonci while cyklus
                        }
                    }
                    else
                    {
                        if (obdl[r].y > 1)
                        {                          //ak nie nula, teda inak, ideme rezat na vysku
                            t = rnd.Next(1, obdl[r].y);               //to iste ako for nad nami len nerezeme na sirku ale na vysku
                            obdl[i + 1].y = obdl[r].y - t;
                            obdl[i + 1].x = obdl[r].x;
                            obdl[r].y = t;
                            spravne = true;
                        }
                    }
                }
                spravne = false;                                //opat vratime na povodnu hodnotu, aby nam v dalsej iteracii for cyklu bezal aj while cyklus
            }
            return obdl;      //ked skonci for, vraciame vysledne pole v ktorom na kazdom policku je objekt s vyskou a sirkou
        }

        void draw_game()
        {
            Invalidate();
            this.GoodGameL.Hide();
            this.AnotherGame.Hide();
            this.blocks = new Block[this.settings.blockCount];
            obdlznik[] ob = new obdlznik[this.settings.blockCount];

            ob[0].x = this.settings.cols;
            ob[0].y = this.settings.rows;
            ob = rozdel(this.settings.blockCount, ob);
            int ix = 0;
            foreach (obdlznik obdl in ob)
            {
                Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int W = obdl.x;
                int H = obdl.y;
                int x = this.settings.rows * this.settings.cell_size;
                int y = ix * this.settings.cell_size;
                int width = this.settings.cell_size * W;
                int height = this.settings.cell_size * H;
                Block block = new Block(ix+1, x + 20, y, width, height, color);
                blocks[ix] = block;
                ix += 1;
            }
        }      

        void GameFormShown(object sender, EventArgs e)
		{
            this.draw_game();
        }

        void GameFormPaint(object sender, PaintEventArgs e)
		{
			// draw playing area
            // it goes first by the colls 
			for( int i=0; i < this.settings.cols; i++)
			{
				for( int j=0; j < this.settings.rows; j++)
				{
					Pen blackPen = new Pen(Color.Black, 1);
					e.Graphics.DrawRectangle(blackPen, i*this.settings.cell_size+INDENT_X, j*this.settings.cell_size+INDENT_Y, this.settings.cell_size, this.settings.cell_size);
				}
			}
            // draw blocks
            foreach(Block block in blocks)
			{
				block.Kresli(e.Graphics);
			}			
		}

        void print_playground()
        {
            for (int r = 0; r < this.settings.rows; r++)
            {
                for (int s = 0; s < this.settings.cols; s++)
                {
                    Debug.Write(Convert.ToString(playground[r, s]));
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine(Convert.ToString(up));
            Debug.WriteLine("");
            up += 1;
        }

		void GameFormMouseDown(object sender, MouseEventArgs e)
		{
            // find block choosen to move
            foreach (Block block in blocks)
			{
				if (e.X < block.x+block.width && e.X > block.x)
				{
					if (e.Y < block.y+block.height && e.Y > block.y)
					{
						selected = block;
                        deltaX = e.X - selected.x;
                        deltaY = e.Y - selected.y;
						clicked = true;
						break;
					}
				}
			}
        }

		void GameFormMouseMove(object sender, MouseEventArgs e)
		{
			if(clicked) 
			{
                int dx = e.X - deltaX;
                int dy = e.Y - deltaY;

                // if in window size
                if (dx > 0 &&  dx + selected.width < this.ClientSize.Width)
                {
                    if(dy > 0 && dy+ selected.height < this.ClientSize.Height)
                    {
                        selected.x = dx;
                        selected.y = dy;
                        Invalidate();
                    }
                }             
			}
		}

        private void AnotherGame_Click(object sender, EventArgs e)
        {
            this.draw_game();
        }

        void GameFormMouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            
            if (selected.x >= 0 && selected.x < this.settings.cols * this.settings.cell_size)
            {
                if (selected.y >= 0 && selected.y < this.settings.rows * this.settings.cell_size)
                {
                    selected.x = (selected.x / this.settings.cell_size) * this.settings.cell_size;
                    selected.y = (selected.y / this.settings.cell_size) * this.settings.cell_size;
                }
            }
            Invalidate();
            deltaX = 0;
            deltaY = 0;


            this.print_playground();

            // check game over
            int num = 0;
            for (int r = 0; r < this.settings.rows; r++)
            {
                for (int s = 0; s < this.settings.cols; s++)
                {
                    // empty place
                    if (playground[r, s] == 0)
                    {
                        num += 1;
                    }
                    // occupied but moved - unset
                    else if (playground[r, s] == selected.id)
                    {
                        playground[r, s] = 0;
                    }
                }
            }
            if (num == 0)
            {
                for (int r = 0; r < this.settings.rows; r++)
                {
                    for (int s = 0; s < this.settings.cols; s++)
                    {
                        // empty place aby sa nam resetla po vyhrati matica na nuly
                        playground[r, s] = 0;
                        
                    }
                }
                GoodGameL.Show();
                AnotherGame.Show();
            }

            // _________________SEM TO NESEDI_________________

            int fromX = selected.x / this.settings.cell_size;
            int fromY = selected.y / this.settings.cell_size;
            //int toX = selected.width / this.settings.cell_size;
            //int toY = selected.height / this.settings.cell_size;

            int toX = (selected.width / this.settings.cell_size) + fromX; //prerobil som tieto 2 premenne
            int toY = (selected.height / this.settings.cell_size) + fromY;  //

            Debug.WriteLine(fromX + " " + fromY);
            Debug.WriteLine(toX + " " + toY);

            // set ocupied space to selected block id
            for (int r = fromY; r <= toY; r++)
            {
                for (int s = fromX; s < toX; s++)
                {
                    // to be occupied
                    if ((r < settings.rows) &&(s < settings.cols)) {  //doplnil som tento if!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        playground[r, s] = selected.id;
                    }
                }
            }
            this.print_playground();
        }


        private void GameFormKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int r = 0; r < this.settings.rows; r++)
                {
                    for (int s = 0; s < this.settings.cols; s++)
                    {
                        // empty place aby sa nam resetla po vyhrati matica na nuly
                        playground[r, s] = 0;

                    }
                }
                this.Hide();
                mainForm.Show();
            }
        }
        /*
        protected virtual void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {    
            if (e.KeyCode == Keys.K)
            {
                this.Hide();
                mainForm.Show();
            }
        }*/

    }
}
