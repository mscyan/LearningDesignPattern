using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08门面_外观_模式
{
	class Program
	{
		static void Main(string[] args)
		{
			Facade f = new Facade();
			f.Operation();

			f.Operation2();

			Console.Read();
		}
	}
}
