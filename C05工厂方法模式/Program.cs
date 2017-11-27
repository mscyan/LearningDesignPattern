using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05工厂方法模式
{
	class Program
	{
		static void Main(string[] args)
		{
			//LeiFeng Undergraduate = new Undergraduate();
			//Undergraduate.BuyRice();
			LeiFeng studentA = SimpleFactory.CreateLeiFeng("大学生");
			studentA.Sweep();
			LeiFeng studentB = SimpleFactory.CreateLeiFeng("志愿者");
			studentB.BuyRice();

			IFactory factory = new UndergraduateFactory();
			LeiFeng student1 = factory.CreateLeiFeng();
			student1.BuyRice();
			student1.Sweep();
			student1.Wash();
		}
	}
	//class Animal
	//{
	//	protected string name = "default_name";
	//	public Animal()
	//	{
	//		Console.WriteLine("class Animal : "+name);
	//	}
	//	public virtual void Shout()
	//	{
	//		Console.WriteLine("Animal Function Shout : "+name);
	//	}
	//}
	//class Dog:Animal
	//{
	//	string name = "default_dog_name";
	//	public Dog() : base()
	//	{
	//		Console.WriteLine("class Dog : "+name);
	//	}
	//	public new void Shout()
	//	{
	//		Console.WriteLine("Dog Function Shout : "+name);
	//	}
	//}
}
