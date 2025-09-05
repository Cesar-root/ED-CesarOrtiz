using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clase_Coche
{
    internal class Libro
    {
		private string strTitulo;

		public string Titulo
		{
			get { return strTitulo; }
			set { strTitulo = value; }
		}
		private string strAutor;

		public string Autor
		{
			get { return strAutor; }
			set { strAutor = value; }
		}
        public override string ToString()
        {
			return "El libro se llama "+Titulo+" del autor "+Autor;
        }

    }
}
