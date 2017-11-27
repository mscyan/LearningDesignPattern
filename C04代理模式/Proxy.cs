using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04代理模式
{
	class Proxy:Subject
	{
		RealSubject real;
		public Proxy(User user)
		{
			real = new RealSubject(user);
		}
		public void request()
		{
			real.request();
		}
	}
}
