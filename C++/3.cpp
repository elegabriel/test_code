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

int FunAdd(string s, int* i);
int FunSub(string s, int* i);
int FunMul(string s, int* i);

int main(int argc, const char * argv[]) {
    // insert code here...
    int num;
    cin>>num;
    string s;
    getline(cin, s);
    
    while (num--) {
        getline(cin, s);//cin>>s;
        int cnt=0;
        int i=0;
        cnt = Expc(s, &i);
        if (i == 0 | i+1 != s.length()) {
            cout<<"invalid expression"<<endl;
        }
        else{
            cout<<cnt<<endl;
        }
    }
    return 0;
}

int Expc(string s,  int* i)
{
    int cnt=0;
    
    int flag = 0;
    if (s.length()<5) {
        return cnt;
    }
    else if (s[*i]!='(') {
        return cnt;
    }
    else if (s[++(*i)]=='+') {
        flag=1;
    }
    else if (s[*i] == '-'){
        flag=2;
    }
    else if(s[*i] == '*'){
        cnt=1;
        flag=3;
    }
    else{
        *i=0;
        return cnt;
    }
    ++(*i);
    
    int num=0;
    for (; *i<s.length(); (*i)++) {
        int tmp=0;
        switch (s[*i]) {
            case '(':
                tmp=Expc(s, i);
                if (*i ==0) {
                    return 0;
                }
                break;
            case '1':
                tmp=1;
                break;
            case '2':
                tmp=2;
                break;
            case '3':
                tmp=3;
                break;
            case '4':
                tmp=4;
                break;
            case '5':
                tmp=5;
                break;
            case '6':
                tmp=6;
                break;
            case '7':
                tmp=7;
                break;
            case '8':
                tmp=8;
                break;
            case '9':
                tmp=9;
                break;
            case '0':
                tmp=0;
                break;
            case ')':
                //++(*i);
                if ( (flag==1&& num<1) | (flag==2 && (num!=1 && num!=2)) | (flag ==3 && num<2)) {
                    *i=0;
                }
                return cnt;
                break;
            case ' ':
                if (flag==3) {
                    tmp=1;
                }
                else{
                    tmp=0;
                }
                num--;
                break;
            default:
                flag =0;
                break;
        }
        if (!flag) {
            *i=0;
            return cnt;
            break;
        }
        switch (flag) {
            case 1:
                cnt+=tmp;
                break;
            case 2:
                if (num) {
                    cnt=-cnt-tmp;
                }
                else
                    cnt-=tmp;
                break;
            case 3:
                cnt*=tmp;
                break;
            default:
                break;
        }
        num++;
    }
    if ( (flag==1&& num<1) | (flag==2 && (num!=1 | num!=2)) | (flag ==3 && num<2)) {
        *i=0;
    }
    return cnt;
}
