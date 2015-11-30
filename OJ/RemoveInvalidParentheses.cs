public class Solution{
       public IList<string> RemoveInvalidParenteses(string s){
       	      List<string> ListOfString = new List<string>();
	      List<string> ResultListOfString = new List<string>();
	      	      	             	      
       	      if (s != null && s.Length == 0) return null;

	      int cnt=0;
	      for (int i=0; i<s.Length ; i++)
	      {
		if (s[i] == '(')  cnt++;
		else (s[i] == ')') cnt--;

		if (cnt<0)
		{
			for (int j=0; j<=i; j++)
			{
				if (s[j] ==')') ListOfString.Add(s.remove(i,1));
			}

			if(i != s.Length-1)
			{
				List<string> SubListOfString =RemoveInvalidParenteses(s.Substring(i+1));
				if(SubListOfString ==null! || SubListOfString.Count ==0) ResultListOfString=  ListOfString;
				else
				{
					for(int k=0;k<ListOfString.Count;k++)
					{
						for(int l=0;l<SubListOfString.Count;l++)
						{
							ResultListOfString.Add(ListOfString[k]+SubListOfString[l]);
						}
					}
				}
			}
		}
		else if(i == s.Length-1 && cnt>0)
		
	      }

       }
}