using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01简单工厂模式
{
	class Program
	{
		static void Main(string[] args)
		{
			Operation opera;
			opera = OperationFactory.createOperation("+");
			opera.NumberA = 292;
			opera.NumberB = 82;
			Console.WriteLine(opera.GetResult());
		}
	}
}
