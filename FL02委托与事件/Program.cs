using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL02委托与事件
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
	class CatShoutEventArgs:EventArgs
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
	class Cat
	{
		private string name;
		public Cat(string name)
		{
			this.name = name;
		}
		public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
		public event CatShoutEventHandler CatShout;
		public void Shout()
		{
			Console.WriteLine("{0}猫叫了",name);
			if(CatShout!=null)
			{
				CatShoutEventArgs e = new CatShoutEventArgs();
				e.Name = this.name;
				CatShout(this, e);
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
		public void Run(object sender,CatShoutEventArgs args)
		{
			Console.WriteLine("猫{0}来了，{1}快跑",args.Name,name);
		}
	}

}
