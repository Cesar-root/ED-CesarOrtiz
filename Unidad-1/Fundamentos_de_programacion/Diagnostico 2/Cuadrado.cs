using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico_2
{
    internal class Cuadrado : Rectangulo
    {

		private double _dblLado;

		private double Lado
		{
			get { return _dblLado; }
			set { _dblLado = value; }
		}

		public override double Area() 
		{
			return Lado*Lado;
		}
        public override double Perimetro()
        {
            return 4*Lado;
        }
        public override string MostrarDimensiones()
        {
            return "Area: " + Area() + "\n" + "Perimetro: " + Perimetro();
        }
        public Cuadrado(double Alto, double Ancho, double lado) : base(Alto, Ancho) 
		{
			_dblLado = lado;
		}


	}
}
