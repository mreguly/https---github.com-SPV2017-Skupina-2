/*
 * Created by SharpDevelop.
 * User: Martin
 * Date: 8.10.2017
 * Time: 23:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Minisoft1
{
	partial class GameForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.AnotherGame = new System.Windows.Forms.Button();
            this.GoodGameL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnotherGame
            // 
            this.AnotherGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnotherGame.Location = new System.Drawing.Point(468, 36);
            this.AnotherGame.Name = "AnotherGame";
            this.AnotherGame.Size = new System.Drawing.Size(87, 23);
            this.AnotherGame.TabIndex = 0;
            this.AnotherGame.Text = "Ďalšia hra";
            this.AnotherGame.UseVisualStyleBackColor = true;
            this.AnotherGame.Click += new System.EventHandler(this.AnotherGame_Click);
            // 
            // GoodGameL
            // 
            this.GoodGameL.AutoSize = true;
            this.GoodGameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoodGameL.Location = new System.Drawing.Point(467, 9);
            this.GoodGameL.Name = "GoodGameL";
            this.GoodGameL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoodGameL.Size = new System.Drawing.Size(88, 24);
            this.GoodGameL.TabIndex = 1;
            this.GoodGameL.Text = "SUPER!!!";
            this.GoodGameL.UseWaitCursor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 348);
            this.Controls.Add(this.GoodGameL);
            this.Controls.Add(this.AnotherGame);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Shown += new System.EventHandler(this.GameFormShown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFormPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseUp);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameFormMyKeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameFormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button AnotherGame;
        private System.Windows.Forms.Label GoodGameL;
    }
}
