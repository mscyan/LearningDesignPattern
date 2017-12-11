using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTest
{
	class Program
	{
		static void Main(string[] args)
		{
			BlackCat bc = new BlackCat();
			bc.show();

			Console.Read();
		}
	}

	class Animal
	{
		public virtual  void show()
		{
			Console.WriteLine("Animal");
		}
	}

	class Cat : Animal
	{
		public override void show()
		{
			Console.WriteLine("Cat");
			//base.show();
		}
	}

	class BlackCat : Cat
	{
		public override void show()
		{
			Console.WriteLine("BlackCat");
			base.show();
		}
	}
}
