
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace biblioteca
{
	/// <summary>
	/// Description of mostrar.
	/// </summary>
	public partial class mostrar : Form
	{
	
		public mostrar()
		{
			
		
			funciones nuevolibro = new funciones();
			
			InitializeComponent();
			
			dataGridView1.DataSource = nuevolibro.mostrartodo();
			dataGridView1.DataMember = "comentario";
			
		}

	}
}
		
	
