using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04代理模式
{
	class Program
	{
		static void Main(string[] args)
		{
			User user = new User();
			user.name = "Tom";
			Proxy proxy = new Proxy(user);
			proxy.request();
		}
	}
}
