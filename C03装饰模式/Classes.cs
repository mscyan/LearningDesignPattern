using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03装饰模式
{
	class Person
	{
		public Person(){}
		private string name;
		public Person(string name)
		{
			this.name = name;
		}
		public virtual void Show()
		{
			Console.WriteLine("    装扮的{0}",name);
		}
	}

	class Finery:Person
	{
		protected Person component;
		public void Decorate(Person person)
		{
			this.component = person;
		}
		public override void Show()
		{
			if(component!=null)
			{
				Console.Write("."); component.Show();
				Console.WriteLine("Finery类的show()方法");
			}
		}
	}

	class Tshirts : Finery
	{
		public override void Show()
		{
			Console.WriteLine("大T恤");
			base.Show();
			Console.WriteLine("++++"+base.component.ToString());
		}
	}

	class BigTrouser : Finery
	{
		public override void Show()
		{
			Console.WriteLine("跨裤");
			//base.Show();
			Console.WriteLine("----"+base.component.ToString());
		}
	}
}
