using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico_2
{
    internal class Rectangulo
    {
		private double _dblAncho;

		private double Ancho
		{
			get { return _dblAncho; }
			set { _dblAncho = value; }
		}
		private double _dblAlto;

		private double Alto
		{
			get { return _dblAlto; }
			set { _dblAlto = value; }
		}

		public  virtual double Area() 
		{
			return Alto * Ancho;
		}
		public virtual double Perimetro() 
		{ 
			return 2*(Alto)+2*(Ancho);
		}
		public  virtual string MostrarDimensiones() 
		{
			return "Area: "+Area()+"\n"+"Perimetro: "+Perimetro();
		}
		public Rectangulo(double Alto, double Ancho) 
		{
			_dblAlto= Alto;
			_dblAncho= Ancho;
		}
	}
}
