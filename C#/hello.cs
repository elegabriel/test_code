using System;

class Helloworld
{
	static void Main(){
		//单字符读入+类型转换
		int readValue;char character;
		//读入的readValue为字符的值,如'1'=49, 只读入一个字符
		readValue = System.Console.Read();
		//(char)将int转换为数值对应的字符,如,'/49'=1,readValue=49,则character='/49'＝’1‘
		//不允许直接类型转换character = readValue
		character = (char) readValue;
		System.Console.WriteLine(character);

		//行读入+打印参数传递
		string firstName;string lastName;
		System.Console.WriteLine("Hey You!");
		System.Console.Write("Enter your first name: ");
		firstName = System.Console.ReadLine();
		System.Console.Write("Enter your last name: ");
		lastName = System.Console.ReadLine();
		System.Console.WriteLine(
			"You full name is {0} {1}.",firstName, lastName);

		//基础打印+转义
		System.Console.WriteLine("Hello World!");
		System.Console.WriteLine('\'');
		//Unicode
		System.Console.Write('\u003A');
		System.Console.WriteLine('\u0029');
		//string
		System.Console.Write("\"Truly, you have a dizzying intellect.\"");
		System.Console.Write("\n\"Wait 'till I get going!\n");
		//@
		System.Console.Write(@"begin
		         /\
		        /  \
		       /    \
		      /      \
		     /________\
end
"		);


		//string
		string text,firstName,lastName;
		firstName = "ele"; lastName = "Ezio";
		text = string.Format("Your full name is {0} {1}.",firstName, lastName);
		System.Console.WriteLine(text);

		//衔接没有空格
		text = string.Concat(firstName, lastName);
		System.Console.WriteLine(text);

		string option = "/Help";
		//第三个参数为true时，忽略大小写
		int result = string.Compare(option, "/help", true);
		System.Console.WriteLine(result);

		lastName="Dr. Hello Ph.D.";
		bool isPhd = lastName.EndsWith("Ph.D.");
		bool isDr = lastName.StartsWith("Dr.");
		System.Console.WriteLine("Is Phd? {0} Is Dr? {1}",isPhd,isDr);
		System.Console.WriteLine(lastName.ToLower());//ToUpper
		System.Console.WriteLine(lastName.Trim('D'));//去除首尾的D,只支持传入char[]
		lastName="  Hello World  ";
		System.Console.WriteLine(lastName.Trim());//去除首尾的空格
		System.Console.WriteLine(lastName.TrimStart());//去除首部的空格
		System.Console.WriteLine(lastName.TrimEnd());//去除尾部的空格




	}
}