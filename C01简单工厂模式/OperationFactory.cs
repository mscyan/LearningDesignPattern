using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01简单工厂模式
{
	class OperationFactory
	{
		public static Operation createOperation(string operate)
		{
			Operation oper = null;
			switch (operate)
			{
				case "+":
					oper = new OperationAdd();
					break;
				case "-":
					oper = new OperationSub();
					break;
				case "*":
					oper = new OperationMul();
					break;
				case "/":
					oper = new OperationDiv();
					break;
				default:
					break;
			}
			return oper;
		}

	}
}
