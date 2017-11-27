using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04代理模式
{
	class RealSubject : Subject
	{
		User user;
		public RealSubject(User user)
		{
			this.user = user;
		}
		public void request()
		{
			Console.WriteLine("send request to "+user.name);
		}
	}
}
