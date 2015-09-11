interface IBase
{
	void PrintHello();
}

interface IPrint:IBase
{
	string[] HelloWorld
	{
		get;
	}
}

class Contact : IPrint
{
	void IBase.PrintHello()//void IPrint.PrintHello()会引发错误，显式实现必须通过IBase
	{
		System.Console.WriteLine("HELLO");
	}
	

//	#region IPrint Members
	string[] IPrint.HelloWorld	//前者为显式实现接口，只能由接口本身调用
		 			//隐式实现如下(用类的公共成员)
		 		  	//public string[] HelloWorld
	{
		get
		{
			return new string[]
			{
				"Hello",
				"World"
			};
		}
	}
//	#endregion
}

class Program
{
	public static void Main()
	{
		Contact contact = new Contact();
		foreach (string s in ((IPrint)contact).HelloWorld)	//in contact.HelloWorld
		{
			System.Console.WriteLine(s);
		}
	}
}