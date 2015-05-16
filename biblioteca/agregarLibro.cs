
using System;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
	/// <summary>
	/// </summary>
	public partial class agregarLibro : Form
	{
		public agregarLibro()
		{

			InitializeComponent();
			

		}
		
		void Button1Click(object sender, EventArgs e)
		{ 
			
			
			funciones nuevolibro = new funciones();
			int codigo=0;
		
			string autor=txtAutor.Text;
			string titulo=txtTitulo.Text;
			string descripcion=txtDescripcion.Text;
			string codigoString =txtId.Text;
			string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			codigo = Convert.ToInt32(codigoString);
			nuevolibro.insertarRegistroNuevo(codigo, autor, titulo, descripcion,fecha);
			
			txtAutor.Text = "";
			txtDescripcion.Text ="";
			txtTitulo.Text="";
			txtId.Text="";
			codigo =+ 1;
			
		}
		
	}
}
