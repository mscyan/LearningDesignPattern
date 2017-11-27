using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08门面_外观_模式
{
	/// <summary>
	/// 外观类
	/// 调用需要执行的类的操作
	/// </summary>
	class Facade
	{
		SubSystem1 ss1;
		SubSystem2 ss2;
		SubSystem3 ss3;

		public Facade()
		{
			ss1 = new SubSystem1();
			ss2 = new SubSystem2();
			ss3 = new SubSystem3();
		}

		public void Operation()
		{
			Console.WriteLine("门面类统一执行的操作步骤一");
			ss1.Method1();
			ss2.Method2();
			ss3.Method3();
		}

		public void Operation2()
		{
			Console.WriteLine("门面类统一执行的操作步骤二");
			ss1.Method1();
			ss2.Method2();
			ss3.Method3();
		}
	}
}
