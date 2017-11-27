using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06原型模式
{
	class Program
	{
		static void Main(string[] args)
		{
			//	ConcretePrototype1 p1 = new ConcretePrototype1("001");

			//	ConcretePrototype1 p2 = (ConcretePrototype1)p1.Clone();

			//	Console.WriteLine(p2.Id);

			/*  浅复制
			Resume resume = new Resume("Tom");
			resume.setPersonInfo("Male", "20");
			resume.setWorkExperience("2015-05-05", "MS");

			Resume b = (Resume)resume.Clone();
			b.setPersonInfo("Male", "40");
			resume.setWorkExperience("2015-05-05", "Google");

			Resume c = (Resume)resume.Clone();
			c.setPersonInfo("Male", "30");
			resume.setWorkExperience("2015-05-05", "Apple");

			resume.Display();
			b.Display();
			c.Display();

			Console.WriteLine(c==b);
			*/


			//深复制
			DeepResume dr = new DeepResume("Mary");
			dr.setPersonInfo("Female", "25");
			dr.setWorkExperience("2017-05-09", "MS");

			DeepResume newDr = (DeepResume)dr.Clone();
			newDr.setWorkExperience("2008-08-08", "Google");
			//newDr.setPersonInfo("Female", "30");

			dr.Display();
			newDr.Display();


			Console.WriteLine(dr==newDr);
		}
	}
}
