using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	/// <summary>
	/// main class
	/// </summary>
	/// <remarks>class calculator dapat membuat operasi penambahan, perkalian, dan pembagian (subtract)</remarks>
	public class Calculator
	{
		/// <summary>
		/// Operasi Pertambahan
		/// </summary>
		/// <param name="a">angka pertama dalam operasi pertambahan</param>
		/// <param name="b">angka kedua dalam operasi pertambahan</param>
		/// <return>hasil dari pertambahan angka pertama dan kedua</return>
		public double Tambah(double a, double b)
		{
			return a + b;
		}
		/// <summary>
		/// Operasi Perkalian
		/// </summary>
		/// <param name="a">angka pertama dalam operasi perkalian</param>
		/// <param name="b">angka kedua dalam operasi perkalian</param>
		/// <return>hasil dari perkalian angka pertama dan kedua</return>
		public double Kali(double a, double b)
		{
			return a * b;
		}
		/// <summary>
		/// Operasi Pembagian
		/// </summary>
		/// <param name="a">angka pertama dalam operasi pembagian</param>
		/// <param name="b">angka kedua dalam operasi pembagian</param>
		/// <return>hasil dari pembagian angka pertama dan kedua</return>
		public double Bagi(double a, double b)
		{
			return a / b;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			double a = Double.Parse(args[0]);
			double b = Double.Parse(args[1]);

			Calculator cc = new Calculator();

			double tb = cc.Tambah(a, b);
			double kl = cc.Kali(a, b);
			double bg = cc.Bagi(a, b);

			Console.WriteLine("Penjumlahan = {0}", tb);
			Console.WriteLine("Perkalian = {0}", kl);
			Console.WriteLine("Pembagian = {0}", bg);
		}
	}
}