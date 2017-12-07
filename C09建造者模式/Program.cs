using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09建造者模式
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	//指挥者 Director
	class BuilderDirector
	{
		private AbstractPersonBuilder builder;
		public BuilderDirector(AbstractPersonBuilder builder)
		{
			this.builder = builder;
		}

		public void CreatePerson()
		{
			builder.BuildHead();
			builder.BuildArm();
			builder.BuildBody();
			builder.BuildLeg();
		}

	}

	abstract class AbstractPersonBuilder
	{
		protected int height;
		protected string name;

		public AbstractPersonBuilder(int height,string name)
		{
			this.height = height;
			this.name = name;
		}

		public abstract void BuildHead();
		public abstract void BuildBody();
		public abstract void BuildArm();
		public abstract void BuildLeg();
	}

	class FatPersonBuilder : AbstractPersonBuilder
	{
		public FatPersonBuilder(int height,string name):base(height,name)
		{

		}

		public override void BuildArm()
		{
			
		}

		public override void BuildBody()
		{
			
		}

		public override void BuildHead()
		{
			
		}

		public override void BuildLeg()
		{
			
		}
	}

	class ThisPersonBuilder : AbstractPersonBuilder
	{
		public ThisPersonBuilder(int height,string name) : base(height, name)
		{

		}

		public override void BuildArm()
		{
			
		}

		public override void BuildBody()
		{
			
		}

		public override void BuildHead()
		{
			
		}

		public override void BuildLeg()
		{
			
		}
	}
}
