using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07模版方法模式
{
	class Program
	{
		static void Main(string[] args)
		{

			ConcreteClassA cc = new ConcreteClassA();
			cc.TemplateMethod();

			Console.WriteLine();

			ConcreteClassB cb = new ConcreteClassB();
			cb.TemplateMethod();
		}
	}

	abstract class AbstractClass
	{
		public abstract void PrimitiveOperation1();
		public abstract void PrimitiveOperation2();

		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
			Console.WriteLine("模版方法执行");
		}
	}

	class ConcreteClassA:AbstractClass
	{
		public override void PrimitiveOperation1()
		{
			Console.WriteLine("Concrete Method A");
		}
		public override void PrimitiveOperation2()
		{
			Console.WriteLine("Concrete Method B");
		}
	}

	class ConcreteClassB:AbstractClass
	{
		public override void PrimitiveOperation1()
		{
			Console.WriteLine("实际方法 A");
		}
		public override void PrimitiveOperation2()
		{
			Console.WriteLine("实际方法 B");
		}
	}
}
