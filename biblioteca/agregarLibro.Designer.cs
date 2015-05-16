/*
 * Created by SharpDevelop.
 * User: Josue01
 * Date: 03/05/2015
 * Time: 09:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace biblioteca
{
	partial class agregarLibro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Modern No. 20", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(18, 425);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(390, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Autor";
			// 
			// txtAutor
			// 
			this.txtAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtAutor.Location = new System.Drawing.Point(18, 97);
			this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(388, 26);
			this.txtAutor.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 157);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 35);
			this.label2.TabIndex = 3;
			this.label2.Text = "Titulo";
			// 
			// txtTitulo
			// 
			this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtTitulo.Location = new System.Drawing.Point(20, 198);
			this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(386, 26);
			this.txtTitulo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 260);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 35);
			this.label3.TabIndex = 5;
			this.label3.Text = "Descripcion";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtDescripcion.Location = new System.Drawing.Point(18, 302);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(388, 112);
			this.txtDescripcion.TabIndex = 6;
			// 
			// txtId
			// 
			this.txtId.BackColor = System.Drawing.Color.LightGray;
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Location = new System.Drawing.Point(86, 14);
			this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(47, 26);
			this.txtId.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 14);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 35);
			this.label4.TabIndex = 8;
			this.label4.Text = "ID";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightGray;
			this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(165, 14);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(298, 27);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// agregarLibro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(476, 492);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "agregarLibro";
			this.Text = "Agregar_Libro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
