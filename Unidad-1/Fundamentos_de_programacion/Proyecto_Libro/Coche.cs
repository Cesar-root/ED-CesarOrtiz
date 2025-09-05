using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Libro
{
    internal class Coche
    {
		private string strMarca;

		public string Marca
		{
			get { return strMarca; }
			set { strMarca = value; }
		}
		private string strModelo;

		public string Modelo
		{
			get { return strModelo; }
			set { strModelo = value; }
		}
		private double dblVelocidad;

		public double Velocidad
		{
			get { return dblVelocidad; }
			set { dblVelocidad = value; }
		}
		public string Acelerar() 
		{
			return "El carro hace run run";
		}
		public string Frenar() 
		{
			return "El carrro ha frenado";
		}
	}
}
