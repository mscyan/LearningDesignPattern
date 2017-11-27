using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02策略模式
{
	class Context
	{
		Strategy strategy;
		public Context(string str)//简单工厂和策略模式结合
		{
			switch (str)
			{
				case "A":
					this.strategy = new ConcreteStrategyA();
					break;
				case "C":
					this.strategy = new ConcreteStrategyB();
					break;
				case "B":
					this.strategy = new ConcreteStrategyC();
					break;
				default:
					break;
			}
		}
		public Context(Strategy strategy)
		{
			this.strategy = strategy;
		}
		public void ContextInterface()
		{
			strategy.AlgorithmInterface();
		}
	}
}
