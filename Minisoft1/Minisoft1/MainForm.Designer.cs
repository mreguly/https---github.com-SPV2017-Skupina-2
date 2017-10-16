/*
 * Created by SharpDevelop.
 * User: Martin
 * Date: 7.10.2017
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Minisoft1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label TapetyLabel;
		private System.Windows.Forms.Label ColsLabel;
		private System.Windows.Forms.Label CellLabel;
		private System.Windows.Forms.Button ButtonPlay;
		private System.Windows.Forms.Label BlockLabel;
		private System.Windows.Forms.NumericUpDown NumberOfRows;
		private System.Windows.Forms.NumericUpDown NumberOfCols;
		private System.Windows.Forms.NumericUpDown CellSize;
		private System.Windows.Forms.NumericUpDown CountOfBlocks;
		private System.Windows.Forms.Label RowsLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.TapetyLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.CellLabel = new System.Windows.Forms.Label();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.NumberOfRows = new System.Windows.Forms.NumericUpDown();
            this.NumberOfCols = new System.Windows.Forms.NumericUpDown();
            this.CellSize = new System.Windows.Forms.NumericUpDown();
            this.CountOfBlocks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfBlocks)).BeginInit();
            this.SuspendLayout();
            // 
            // TapetyLabel
            // 
            this.TapetyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TapetyLabel.Location = new System.Drawing.Point(8, 8);
            this.TapetyLabel.Name = "TapetyLabel";
            this.TapetyLabel.Size = new System.Drawing.Size(184, 24);
            this.TapetyLabel.TabIndex = 0;
            this.TapetyLabel.Text = "TAPETY - Nastavenia";
            // 
            // RowsLabel
            // 
            this.RowsLabel.Location = new System.Drawing.Point(16, 40);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(88, 16);
            this.RowsLabel.TabIndex = 1;
            this.RowsLabel.Text = "Počet riadkov:";
            // 
            // ColsLabel
            // 
            this.ColsLabel.Location = new System.Drawing.Point(16, 64);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(88, 16);
            this.ColsLabel.TabIndex = 2;
            this.ColsLabel.Text = "Počet stĺpcov:";
            // 
            // CellLabel
            // 
            this.CellLabel.Location = new System.Drawing.Point(16, 88);
            this.CellLabel.Name = "CellLabel";
            this.CellLabel.Size = new System.Drawing.Size(88, 16);
            this.CellLabel.TabIndex = 3;
            this.CellLabel.Text = "Veľkosť štvorca:";
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(72, 144);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlay.TabIndex = 4;
            this.ButtonPlay.Text = "Hrať";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlayClick);
            // 
            // BlockLabel
            // 
            this.BlockLabel.Location = new System.Drawing.Point(16, 112);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(88, 16);
            this.BlockLabel.TabIndex = 5;
            this.BlockLabel.Text = "Počet tapiet:";
            // 
            // NumberOfRows
            // 
            this.NumberOfRows.Location = new System.Drawing.Point(104, 40);
            this.NumberOfRows.Name = "NumberOfRows";
            this.NumberOfRows.Size = new System.Drawing.Size(48, 20);
            this.NumberOfRows.TabIndex = 10;
            this.NumberOfRows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumberOfRows.ValueChanged += new System.EventHandler(this.NumberOfRows_ValueChanged);
            // 
            // NumberOfCols
            // 
            this.NumberOfCols.Location = new System.Drawing.Point(104, 64);
            this.NumberOfCols.Name = "NumberOfCols";
            this.NumberOfCols.Size = new System.Drawing.Size(48, 20);
            this.NumberOfCols.TabIndex = 11;
            this.NumberOfCols.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumberOfCols.ValueChanged += new System.EventHandler(this.NumberOfCols_ValueChanged);
            // 
            // CellSize
            // 
            this.CellSize.Location = new System.Drawing.Point(104, 88);
            this.CellSize.Name = "CellSize";
            this.CellSize.Size = new System.Drawing.Size(48, 20);
            this.CellSize.TabIndex = 12;
            this.CellSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CellSize.ValueChanged += new System.EventHandler(this.CellSize_ValueChanged);
            // 
            // CountOfBlocks
            // 
            this.CountOfBlocks.Location = new System.Drawing.Point(104, 112);
            this.CountOfBlocks.Name = "CountOfBlocks";
            this.CountOfBlocks.Size = new System.Drawing.Size(48, 20);
            this.CountOfBlocks.TabIndex = 13;
            this.CountOfBlocks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.CountOfBlocks);
            this.Controls.Add(this.CellSize);
            this.Controls.Add(this.NumberOfCols);
            this.Controls.Add(this.NumberOfRows);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.CellLabel);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.TapetyLabel);
            this.Name = "MainForm";
            this.Text = "Minisoft1";
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfBlocks)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
