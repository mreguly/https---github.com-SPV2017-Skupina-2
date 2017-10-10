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
			this.SuspendLayout();
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 344);
			this.Name = "GameForm";
			this.Text = "GameForm";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFormPaint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameFormMouseUp);
			this.ResumeLayout(false);

		}
	}
}
