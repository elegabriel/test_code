//
//  main.cpp
//  test
//
//  Created by ele on 8/4/15.
//  Copyright (c) 2015 ele. All rights reserved.
//

#include <iostream>
using namespace std;
#include <string>
#include <math.h>

string ChangString(string s);
int Manacher(string s, int * p);

int main(int argc, const char * argv[]) {
    // insert code here...
    int num;
    string s;
    int *p = new int[1000000];
    cin>>num;
    while (num--) {
        cin>>s;
        s = ChangString(s);
        cout<<Manacher(s,p)<<endl;
    }
    return 0;
}

string ChangString(string s){
   int i;
   char * cs = new char [2*s.length()+2];
   for (i =0; i<s.length(); i++) {
       cs[i*2]='#';
       cs[i*2+1]=s[i];
   }
   cs[i*2] = '#';
   cs[i*2+1] = '\0';
   return (string)cs;
}

// string ChangString(string s){
//     int i;
//     for (i=0; i<s.length(); i++) {
//         s.insert(i++, "#");
//     }
//     s.insert(i, "#");
//     return s;
// }

int Manacher(string s, int *p)
{
    int ans, id, maxid, i;
    id = maxid = 0;
    ans =1;
    
    for (i=0; i<s.length(); i++) {
        if (maxid >id) {
            p[i] = min(p[id*2-i], maxid-i);
        }
        else
            p[i] = 1;
        
        while (i+p[i]<s.length() && i-p[i]>=0 && s[i-p[i]] == s[i+p[i]]) {
            p[i]++;
        }
        
        if (p[i]+i-1>maxid) {
            id = i;
            maxid = p[i] -1 +i;
        }
        
        if (ans<p[i]) {
            ans = p[i];
        }
    }
    return ans-1;
}