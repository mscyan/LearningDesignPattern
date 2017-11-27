using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02策略模式
{
	abstract class Strategy
	{
		public abstract void AlgorithmInterface();
	}
	class ConcreteStrategyA:Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Concrete Function A");
		}
	}
	class ConcreteStrategyB : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Concrete Function B");
		}
	}
	class ConcreteStrategyC : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Concrete Function C");
		}
	}
}
