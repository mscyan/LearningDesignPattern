using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05工厂方法模式
{
	class SimpleFactory
	{
		public static LeiFeng CreateLeiFeng(string type)
		{
			LeiFeng result = null;
			switch (type)
			{
				case "大学生":
					result = new Undergraduate();
					break;
				case "志愿者":
					result = new Volunteer();
					break;
				default:
					break;
			}
			return result;
		}
	}
}
