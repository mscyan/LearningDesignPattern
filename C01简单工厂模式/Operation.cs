using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01简单工厂模式
{
	class Operation
	{
		private double _numberA = 0;
		private double _numberB = 0;
		public double NumberA
		{
			get { return _numberA; }
			set { _numberA = value; }
		}
		public double NumberB
		{
			get { return _numberB; }
			set { _numberB = value; }
		}
		public virtual double GetResult()
		{
			double result = 0;
			return result;
		}
	}
	class OperationAdd:Operation
	{
		public override double GetResult()
		{
			double result;
			result = NumberA + NumberB;
			return result;
		}
	}
	class OperationSub : Operation
	{
		public override double GetResult()
		{
			double result;
			result = NumberA - NumberB;
			return result;
		}
	}
	class OperationMul : Operation
	{
		public override double GetResult()
		{
			double result;
			result = NumberA * NumberB;
			return result;
		}
	}
	class OperationDiv : Operation
	{
		public override double GetResult()
		{
			double result;
			if (NumberB == 0)
				throw new Exception("除数不能为0");
			result = NumberA / NumberB;
			return result;
		}
	}
}
