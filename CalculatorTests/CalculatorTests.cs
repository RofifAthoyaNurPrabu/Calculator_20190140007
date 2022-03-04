using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{

	[TestFixture()]
	public class CalculatorTests
	{
	
		Calculator cc = new Calculator();

		[SetUp()]
		public void init()
		{
			cc = new Calculator();
		}

		[Test()]
		public void TambahTest()
		{
			double hasilTb = cc.Tambah(4, 5);
			Assert.AreEqual(9, hasilTb);
		}

		[Test()]
		public void KaliTest()
		{
			double hasilKl = cc.Kali(4, 5);
			Assert.AreEqual(20, hasilKl);
		}

		[Test()]
		public void BagiTest()
		{
			double hasilBg = cc.Bagi(4, 5);
			Assert.AreEqual(0.8, hasilBg);
		}
	}
}