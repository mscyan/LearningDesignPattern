using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace C06原型模式
{
	class WorkExperience:ICloneable
	{
		private string workDate;
		public string WorkDate
		{
			get { return workDate; }
			set { workDate = value; }
		}
		private string company;
		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		public Object Clone()
		{
			return (Object)this.MemberwiseClone();
		}
	}

	//class Resume : ICloneable
	//{
	//	private string name;
	//	private string sex;
	//	private string age;

	//	private WorkExperience work;

	//	public Resume(string name)
	//	{
	//		this.name = name;
	//		work = new WorkExperience();
	//	}

	//	public void setPersonInfo(string sex, string age)
	//	{
	//		this.sex = sex;
	//		this.age = age;
	//	}

	//	public void setWorkExperience(string workDate, string company)
	//	{
	//		work.WorkDate = workDate;
	//		work.Company = company;
	//	}

	//	public void Display()
	//	{
	//		Console.WriteLine("{0} {1} {2}", name, sex, age);
	//		Console.WriteLine("Work experience: {0} {1}", work.WorkDate, work.Company);
	//	}

	//	public object Clone()
	//	{
	//		return (Object)this.MemberwiseClone();
	//	}
	//}

	class DeepResume : ICloneable
	{
		private string name;
		private string sex;
		private string age;

		private WorkExperience work;

		public DeepResume(string name)
		{
			this.name = name;
			work = new WorkExperience();
		}

		private DeepResume(WorkExperience work)
		{
			this.work = (WorkExperience)work.Clone();
		}

		public void setPersonInfo(string sex, string age)
		{
			this.sex = sex;
			this.age = age;
		}

		public void setWorkExperience(string workDate, string company)
		{
			work.WorkDate = workDate;
			work.Company = company;
		}

		public void Display()
		{
			Console.WriteLine("{0} {1} {2}", name, sex, age);
			Console.WriteLine("Work experience: {0} {1}", work.WorkDate, work.Company);
		}

		public Object Clone()
		{
			DeepResume obj = new DeepResume(this.work);
			obj.name = this.name;
			obj.sex = this.sex;
			obj.age = this.age;
			return obj;
		}

	}
}