//
//  test.cpp
//  
//
//  Created by ele on 8/4/15.
//
//

#include "test.h"
#include <iostream>
using namespace std;

int i =1;
extern const int bufsize;
class A
{
  int a;
  double b;
  int c;
public:
  void PrintFirst()
  {
    cout<<"&a-&c"<<&a-&c<<endl;
  };
  void PrintSecond()
  {
    
  }
  
};
int main()
{
  //  unsigned char a = 0xA5;
  //  unsigned char b = ~a>>4+1;
  //  printf("b=%d\n",b);
  //  long double i;
  //  double j;
  //  cout<<sizeof(i)<<" long double"<<endl;
  //  cout<<sizeof(j)<<" double"<<endl;
  //  cout<<sizeof(float)<<" float"<<endl;
  //  int a[3]={1,2,3};
  //int a;
  double f;
  int a, b;
  a=b=1;
  int *p;double *q;
  p=&a;
  q=&f;
  long c,d;
  c=(long)p;
  d=(long)q;
  
  cout<<"p "<<p<<";c "<<c<<endl;
  cout<<"q "<<q<<";d "<<d<<endl;
  //  cout<<"a[q-p] "<<a[q-p]<<endl;
  cout<<"q-p "<<q-(double *)p<<";d-c "<<d-c<<endl;
  
  return i;
}
