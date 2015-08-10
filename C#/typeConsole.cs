using System;

class TypePrint{
	static void Main()
	{
		uint u1 = 32u;
		long l1 = 64l;
		ulong ul1 = 64ul;
		float f1 = 1.5f;
		double d1 = 1.618033988749895;
		System.Console.WriteLine(d1);
		System.Console.WriteLine(1.618033988749895M);
		System.Console.WriteLine("{0:R}",1.618033988749895);//round-trip 将round-trip格式说明的字符串转换回数值肯定能获得原始值
		System.Console.WriteLine(0x002A);
		System.Console.WriteLine("0x{0:x}",42);

		const double number = 1.618033988749895;
		double result;
		string text;

		//没有R数值不同
		text = string.Format("{0}",number);
		System.Console.WriteLine(text);
		result = double.Parse(text);
		System.Console.WriteLine("{0}: result != number", result != number);

		text = string.Format("{0:R}",number);
		System.Console.WriteLine(text);
		result = double.Parse(text);
		System.Console.WriteLine("{0}: result == number", result == number);

		string option;
		option = "A";
		//string.Compare 对比字符串,true表示不区分大小写
		//bool数据类型实际大小是一个字节
		int comparison = string.Compare(option, "A", false);
		//为何输出结果为0 ?
		System.Console.WriteLine(comparison);
	}
}