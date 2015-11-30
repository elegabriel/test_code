public class Program {
       public class FClass{
       	      public void Print()
	      {
		System.Console.WriteLine("Hello");
		}
	}
	public class SClass:FClass
	{
		public void SPrint()
		{
			Print();
		}
	}

	static public void Main()
	{
		int num;
		double result = 1, sum=0;

		if(int.TryParse(System.Console.ReadLine(), out num))
		{
			while(num-- != 0)
			{
				result/=2;
				sum+=result;
			}

			System.Console.WriteLine(sum);
		}
//		SClass h = new SClass();
//		h.SPrint();
//		System.Console.WriteLine(int.MaxValue);
	}
}