#include <iostream>
#include <stdio.h>
#include <string.h>
using namespace std;
struct{
  short a1;
  short a2;
  short a3;
}A;

struct{
  long a1;
  short a2;
}B;

class C{
  char i[2];
  void f(){cout<<"Hello World"<<endl;}
};

int main()
{
  char* ss1 = "0123456789";
  char ss2[] = "0123456789";
  char ss3[100] = "0123456789";
  int ss4[100];
  char q1[] = "abc";
  char q2[] = "a\n";
  char* q3="a\n";
  char *str1 = (char *) malloc (100);
  void *str2 = (void *) malloc (100);

  cout<<"ss1 "<<sizeof(ss1)<<endl;
  cout<<"ss2 "<<sizeof(ss2)<<endl;
  cout<<"ss3 "<<sizeof(ss3)<<endl;
  cout<<"ss4 "<<sizeof(ss4)<<endl;
  cout<<"q1 "<<sizeof(q1)<<endl;
  cout<<"q2 "<<sizeof(q2)<<endl;
  cout<<"q3 "<<sizeof(q3)<<endl;
  cout<<"A "<<sizeof(A)<<endl;
  cout<<"B "<<sizeof(B)<<endl;
  cout<<"str1 "<<sizeof(str1)<<endl;
  cout<<"str2 "<<sizeof(str2)<<endl;
  cout<<"long "<<sizeof(long)<<endl;
  cout<<"short "<<sizeof(short)<<endl;
  cout<<"string "<<sizeof(string)<<endl;
  cout<<"C "<<sizeof(C)<<endl;
  
  return 0;
}
