using System;

class Helloworld
{
	static void Main(){
		//单字符读入+类型转换
//		int readValue;//string character;
		//读入的readValue为字符的值,如'1'=49, 只读入一个字符
//		readValue = System.Console.Read()-'0';
		//readValue = int.Parse(character);
//		System.Console.WriteLine(readValue);
		//(char)将int转换为数值对应的字符,如,'/49'=1,readValue=49,则character='/49'＝’1‘
		//不允许直接类型转换character = readValue
//		character = (char) readValue;
//		System.Console.WriteLine(character);

		//行读入+打印参数传递
		string firstName;string lastName;
		System.Console.WriteLine("Hey You!");
		System.Console.Write("Enter your first name: ");
//		firstName = System.Console.ReadLine();
		System.Console.Write("Enter your last name: ");
//		lastName = System.Console.ReadLine();
//		System.Console.WriteLine(
//			"You full name is {0} {1}.",firstName, lastName);

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
		string text;
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
		lastName = lastName.Replace("  ", "X");//支持字符串替换，第一个参数为两个空格
		System.Console.WriteLine(lastName);
		//Microsoft Windows 换行时\r\n, Unix为\n
		System.Console.Write("Helloworld"+System.Environment.NewLine);//等同于WriteLine
		System.Console.WriteLine("The lastName, {0}, is {1} characters.", lastName, lastName.Length);
		//string 不可变,只可替换不可修改
		lastName.ToUpper();//可返回大写串，但不改变原串 lastName = lastName.ToUpper()
		System.Console.WriteLine(lastName);

		//大量字符串需要修改，使用System.Text.StringBuilder
		//除了一下函数,还支持Remove()
		// Create a StringBuilder that expects to hold 50 characters.
		// Initialize the StringBuilder with "ABC".
		System.Text.StringBuilder sb = new System.Text.StringBuilder("ABC",50);
		// Append three characters (D, E, and F) to the end of the StringBuilder.
		sb.Append(new char[] {'D', 'E', 'F'});
		Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
		// Append a format string to the end of the StringBuilder.
		sb.AppendFormat("GHI{0}{1}", 'J', 'k');
		Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
		// Insert a string at the beginning of the StringBuilder.
		sb.Insert(0, "Alphabet");
		Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
		// Replace all lowercase k's with uppercase K's.
		sb.Replace('k', 'K');
		Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
		//可给string, System.Text.StringBuilder类置null
		sb=null;

		//var 隐式类型的局部变量
		var text2 = "hello";//var text = System.Console.ReadLine();
		//var text2 = System.Console.Read();//不管是Read还是ReadLine，都会当作字符/字符串处理
		//text2 = (int)text2;text2+=1;//一般当作字符串处理，在后面直接添加一个字符'1'
		//System.Console.WriteLine(text2);
		var uppercase = text2.ToUpper();
		System.Console.WriteLine(uppercase);
		var patent1 = new {Title = "Bifocals", YearOfPublication = "1784"};
		System.Console.WriteLine("{0} ({1})", patent1.Title, patent1.YearOfPublication);

		//在类型后面加?，表示该变量可空，不同于0
		int? a=null;//int b=null; 赋值错误，不能将null传递给int
		System.Console.WriteLine(a);//打印结果为空，

		//使用checked之后，运行时，引发System.OverflowException
		//checked
		unchecked
		//强制不进行溢出检查
		{
			//int.MaxValue 2147483647
			int n = int.MaxValue;
			//-2147483628
			n = n+1;
			System.Console.WriteLine(n);
		}

		

		//隐式转型,从int到long,不会发生精度丢失
		//int intNum = 31416;
		//long longNumber=intNum;

		text = "9.11E-31";
		float kgElectronMass = float.Parse(text);//int.Parse()
		System.Console.WriteLine(kgElectronMass+9.11E-31);

		//System.Convert只支持预定义类型，不可扩展
		string middleCText = "261.626";
		double middleC = System.Convert.ToDouble(middleCText);
		System.Console.WriteLine(middleC+1);
		bool boolean = System.Convert.ToBoolean(middleC);
		System.Console.WriteLine(boolean);
		int intNum = -1;
		System.Console.WriteLine(System.Convert.ToBoolean(intNum));
		//不存在从数值类型到布尔类型的转型, -1是ture还是false; 避免相等操作变成赋值。
		//if(x==42){} if(x=42){}
		//bool boolNum = true;
		//不允许从int直接到bool
		//boolNum = intNum;
		//System.Console.WriteLine(boolNum);

		//所有类型支持ToStringn
		text = boolean.ToString();

//		double dbnumber;
//		string input;
//		System.Console.Write("Enter a number : ");
//		input = System.Console.ReadLine();
//		if(double.TryParse(input, out dbnumber))
//		{
//			//Converted correctly
//		}
//		else
//		{
//			System.Console.WriteLine("The text entered was not a valid number.");
//		}

		string [] languages = {"C#","COBOL","Java","C++","Visual Basic","Pascal","Fortran","Lisp","J#"};

//		string [] languages;
//		languages = new string [] {"A", "B", "C"};

//		string [] languages; //string [] languages = new string [3];
//		languages = new string[3];
//		languages[0] = "c";
		System.Console.WriteLine(languages[0]);

		//default of int is 0
		int count = default(int);
		System.Console.WriteLine(count);

		int [][] cells = {	//int [,] cells={ 为多维数组，元素大小必须完全相同，[][]为交错数组
			new int[]{1,0,2,0},
			new int[]{1,2,0},
			new int[]{1,2},
			new int[]{1}
		};
		//cells.Length只统计元素数目
		System.Console.WriteLine(cells.Length);
		System.Console.WriteLine(languages[0]);
		System.Array.Sort(languages);
		string searchString = "Java";
		int index = System.Array.BinarySearch(languages,searchString);
		System.Console.WriteLine(index);
		//-3 增加三个空格
		System.Console.WriteLine("{0,-3}\t{1,-4}","First Element", "Last Element");
		System.Console.WriteLine("{0,-30}\t{1,-30}","First Element", "Last Element");
		System.Array.Reverse(languages);
		System.Console.WriteLine("{0,-5},{1,-5}",languages[0], languages[1]);
		System.Array.Clear(languages, 0, languages.Length);
		System.Console.WriteLine("{0,-5}, {1, -5}",languages[0], languages[1]);

		float fn=1f;
		System.Console.WriteLine(fn/0);

		System.Console.WriteLine(3.402823E38f*-2f);//上边界约为3.4*10^38,下边界-3.4*10^38;
		
		try{
			AgeCount();
		}
		catch(FormatException)
		{
			Console.WriteLine("Main FormatException");
		}
		finally
		{
			Console.WriteLine("Main finally");
		}
	}
	
	static void AgeCount(){
		
		string ageText;
		int age;
		
		Console.Write("Enter your age:");
		ageText = Console.ReadLine();
		try
		{
			age = int.Parse(ageText);
			Console.WriteLine("Hi! You are {0} months old.",age*12);
		}
		catch(FormatException)
		{
			Console.WriteLine("The int entered, {0}, is not valid.",ageText);
//			throw;
		}
		catch(Exception exception)
		{
			Console.WriteLine("Unexpected error!,{0}", exception.Message);
		}
		finally
		{
			Console.WriteLine("AgeCount finally");
		}
		int [] arr = {0,1,2,3,4};
		int cnt =0;
		System.Console.WriteLine("{0},{1}",arr[cnt],arr[++cnt]);
	}
}