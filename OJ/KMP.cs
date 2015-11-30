using System;

class Program
{
	static void Main()
	{
		int num,err;
		string pat,ori;
		int [] Next = new  int[10000];
		if(int.TryParse(System.Console.ReadLine(), out num))
		{
			while(num-- != 0)
			{
				err = 0;
				pat = System.Console.ReadLine();
				if(pat.Length != 0)
					tryPat(pat, Next);
				else
					err =1;

				ori = System.Console.ReadLine();
				if(ori.Length !=0)
					System.Console.WriteLine(tryOri(pat, ori, Next));
				else
					err =1;

				if(err == 1)
					System.Console.WriteLine(0);
			}
		}
	}

	static void tryPat(string s, int [] next)
	{
		int i,j;
		i=0;j=-1;
		next[0] = -1;

		while(i<s.Length-1)
		{
			if(j == -1 || s[i] == s[j])
			{
				i++;j++;
				next[i]=j;
			}
			else
			{
				j = next[j];
			}
		}

	}

	static int tryOri(string pat, string ori, int [] next)
	{
		int i, j, cnt;
		i=j=cnt=0;

		while(i<ori.Length)
		{
			if(ori[i] == pat[j])
			{
				if(j+1 == pat.Length)
				{
					cnt++;
					if (next[j] == -1)
						i++;
					else
						j=next[j];//j=0;
					//i++;
				}
				else
				{
					j++;i++;
				}
			}
			else
			{
				if(next[j] == -1)
				{
					i++;
				}
				else
				{
					j = next[j];
				}
			}
		}

		return cnt;

	}
}