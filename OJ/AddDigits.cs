public class Solution
{
	public static int AddDigits(int num)
	{
		int result=num;
		System.String s=num.ToString();
		while(s.Length>1)
		{
			result=0;
			foreach (char c in s)
				result+=(c-'0');
			s=result.ToString();
		}
		return (s[0]-'0');
	}

	public static void Main()
	{
		int num;
		System.String inputNum;
		inputNum = System.Console.ReadLine();
		if(!int.TryParse(inputNum,out num))
		{
			System.Console.WriteLine("Not Num");
		}
		else
		{
			System.Console.WriteLine(Solution.AddDigits(num));
		}
	}
}