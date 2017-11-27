using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02策略模式
{
	class Program
	{
		static void Main(string[] args)
		{
			Context c1 = new Context(new ConcreteStrategyB());
			c1.ContextInterface();

			c1 = new Context(new ConcreteStrategyC());
			c1.ContextInterface();

			Context c2 = new Context("A");
			c2.ContextInterface();
		}
	}
}
