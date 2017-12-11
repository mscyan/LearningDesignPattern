using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03装饰模式
{
	class Program
	{
		//将装饰行为按顺序的组合
		static void Main(string[] args)
		{
			//ConcreteComponent cc1 = new ConcreteComponent();
			//ConcreteDecoratorA cda = new ConcreteDecoratorA();
			//ConcreteDecoratorB cdb = new ConcreteDecoratorB();

			//cda.SetComponent(cc1);
			//cdb.SetComponent(cda);

			//cdb.Operation();

			/*
			跨裤
			//.大T恤
			//.    装扮的Jack
			//Finery类的show()方法
			//++++C03装饰模式.Person
			Finery类的show()方法
			----C03装饰模式.Tshirts
			*/

			Person p = new Person("Jack");
			Tshirts t = new Tshirts();
			BigTrouser b = new BigTrouser();
			t.Decorate(p);
			b.Decorate(t);
			b.Show();

			Console.Read();
		}
	}

	abstract class Component
	{
		public abstract void Operation();
	}

	class ConcreteComponent : Component
	{
		public override void Operation()
		{
			Console.WriteLine("具体组件的操作");
		}
	}

	abstract class Decorator : Component
	{
		protected Component component;
		public void SetComponent(Component component)
		{
			this.component = component;
		}

		public override void Operation()
		{
			if (component != null)
			{
				component.Operation();
			}
		}
	}

	class ConcreteDecoratorA : Decorator
	{
		private string addedState;

		public override void Operation()
		{
			base.Operation();
			addedState = "Decorator A";
			Console.WriteLine("具体对象A的操作");
		}
	}

	class ConcreteDecoratorB : Decorator
	{
		public override void Operation()
		{
			base.Operation();
			AddedBehavior();
			Console.WriteLine("具体对象B的操作");
		}

		public void AddedBehavior()
		{

		}
	}
}
