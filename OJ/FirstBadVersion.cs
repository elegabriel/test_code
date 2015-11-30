/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class VersionControl{
    public bool IsBadVersion(int n){
        return (n>1702766718);
    }
}

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int max,min;
        max=n;
        min=1;
        if(!IsBadVersion(n))
            return 0;
        
        while (true)
        {
            if(IsBadVersion(n))
            {
                if(n==1)
                    return 1;
                if(IsBadVersion(n-1)){
                    max=n;
                    n=min/2+max/2;
//                    System.Console.WriteLine(n);
//                    System.Threading.Thread.Sleep(1000);
                }
                else
                    return n;
            }
            else
            {
                if(IsBadVersion(n+1))
                    return n+1;
                else{
                    min = n;
                    n = min/2+max/2;
//                    System.Console.WriteLine(n);
//                    System.Threading.Thread.Sleep(1000);

                }         
            }
        }
    }
}
public class Program{
    static public void Main(){
        Solution s = new Solution();
        System.Console.WriteLine(s.FirstBadVersion(2126753390));
    }
}