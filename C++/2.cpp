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

int Expc(string s, int* i);

int main(int argc, const char * argv[]) {
    // insert code here...
    int num;
    cin>>num;
    string s;
    
    while (num--) {
        cin>>s;
        int cnt=0;
        int tmp = 0;
        for (int i=0; i<s.length(); i++) {
            switch (s[i]) {
                case '(':
                    tmp=Expc(s,&i);
                    break;
                case '2':
                    tmp*=1;
                    break;
                case '3':
                    tmp*=2;
                    break;
                case '4':
                    tmp*=3;
                    break;
                case '5':
                    tmp*=4;
                    break;
                case '6':
                    tmp*=5;
                    break;
                case '7':
                    tmp*=6;
                    break;
                case '8':
                    tmp*=7;
                    break;
                case '9':
                    tmp*=8;
                    break;
                default:
                    tmp=1;
                    break;
            }
            cnt+=tmp;
        }
        cout<<cnt<<endl;
    }
    return 0;
}

int Expc(string s,  int* i)
{
    int cnt=0;
    int tmp=0;
    (*i)++;
    for (; *i<s.length(); (*i)++) {
        switch (s[*i]) {
            case '(':
                tmp=Expc(s, i);
                break;
            case '2':
                tmp*=1;
                break;
            case '3':
                tmp*=2;
                break;
            case '4':
                tmp*=3;
                break;
            case '5':
                tmp*=4;
                break;
            case '6':
                tmp*=5;
                break;
            case '7':
                tmp*=6;
                break;
            case '8':
                tmp*=7;
                break;
            case '9':
                tmp*=8;
                break;
            case ')':
                return cnt;
                break;
            default:
                tmp=1;
                break;
        }
        cnt+=tmp;
    }
    return cnt;
}
