using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL01委托与事件
{
	class Program
	{
		static void Main(string[] args)
		{
			Cat c1 = new Cat("Tom");
			Mouse m1 = new Mouse("Jerry");
			Mouse m2 = new Mouse("Jack");

			c1.CatShout += new Cat.CatShoutEventHandler(m1.Run);
			c1.CatShout += new Cat.CatShoutEventHandler(m2.Run);

			c1.Shout();
		}
	}
	class Cat
	{
		private string name;
		public Cat(string name)
		{
			this.name = name;
		}
		public delegate void CatShoutEventHandler();
		public event CatShoutEventHandler CatShout;
		public void Shout()
		{
			Console.WriteLine("mie,我是{0}",name);
			if(CatShout!=null)
			{
				CatShout();
			}
		}
	}
	class Mouse
	{
		private string name;
		public Mouse(string name)
		{
			this.name = name;
		}
		public void Run()
		{
			Console.WriteLine("猫来了，{0}快跑", name);
		}
	}
}
