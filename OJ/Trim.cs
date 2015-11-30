using System;

public class Program
{
	public const int MAXTRIE = 26;
	public class TrieNode
	{
		TrieNode[] next;
		int cnt;

		public TrieNode()
		{
			cnt=0;
			next = new TrieNode[MAXTRIE];
//			Console.WriteLine(next[25] == null);
		}
		public void TrieInsert(String s)
		{
			if(s.Length == 0)
				return;
			int c = s[0]-'a';
			if(c<0 | c>25)
				return;
			s = s.Substring(1);
//			Console.WriteLine(s);
//			Console.WriteLine(s.Length);
//			cnt++;
			if(next[c] == null)
			{
				next[c] = new TrieNode();
				next[c].cnt++;
			}
			else
			{
				next[c].cnt++;
			}
			if(s.Length != 0)
				next[c].TrieInsert(s);
		}

		public int TrieSearch(String s)
		{
			if(s.Length == 0)
				return 0;
			int c = s[0]-'a';
			if(c<0 | c>25)
				return 0;
			s = s.Substring(1);
			if (next[c] == null)
			{
				return 0;
			}
			else if(s.Length !=0)
			{
				return next[c].TrieSearch(s);
			}
			else
			{
				return next[c].cnt;
			}
		}

		public static void Main()
		{
			TrieNode root = new TrieNode();
			int in1;
			if(int.TryParse(Console.ReadLine(),out in1))
			{
				while(in1-- != 0)
				{
					root.TrieInsert(Console.ReadLine());
				}
			}
			if(int.TryParse(Console.ReadLine(),out in1))
			{
				while(in1-- != 0)
				{
					Console.WriteLine(root.TrieSearch(Console.ReadLine()));
				}
			}
		}

	}


}