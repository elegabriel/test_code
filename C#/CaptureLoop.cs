using System;
using System.Collections.Generic;

class CaptureLoop
{
	static void Main()
	{
		var items = new string[] {"Moe", "Larry", "Curly"};
		var actions = new List<Action>{};
		int i;
		for(i=0;i<items.Length;i++) //foreach (string item in items)
		{
			actions.Add(()=>{ Console.WriteLine(items[i]);});
		}
		for (i=0;i<items.Length;i++)
		{
			actions[i]();
		}
	}
}