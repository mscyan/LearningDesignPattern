using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05工厂方法模式
{
	interface IFactory
	{
		LeiFeng CreateLeiFeng();
	}
	class UndergraduateFactory:IFactory
	{
		public LeiFeng CreateLeiFeng()
		{
			return new Undergraduate();
		}
	}
	class VolunteerFactory:IFactory
	{
		public LeiFeng CreateLeiFeng()
		{
			return new Volunteer();
		}
	}
}
