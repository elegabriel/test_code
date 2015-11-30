#include <iostream>
using namespace std;
#include <string>

int main(int argc, const char * argv[]) {
    // insert code here...
    
    int num;
    cin>>num;
    string s;
    string sample = "9706";
    while (num--) {
        cin>>s;
        int j=0;
        int cnt=0;
        int flag=0;
        int flag2=1;
        for (int i=0; i<s.length(); i++) {
            if (j && flag2 && s[i]==sample[0]) {
                flag2=0;
                flag =i;
            }
            if (s[i] ==sample[j]) {
                if (j==0) {
                    flag=i;
                }
                j++;s[i]='a';
            }
            if (j == 4) {
                cnt++;
                j=0;
                if (i<s.length()) {
                    i=flag;
                    flag2=1;
                }
            }
        }
        cout<<cnt<<endl;
    }
    return 0;
}
