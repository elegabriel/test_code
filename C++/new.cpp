#include <iostream>
using namespace std;

int main()
{
  int * i = new int(100);
  int * j = new int[100];
  cout<<sizeof(j)<<endl;
  cout<<sizeof(new int[100])<<endl;

  return 0;
}
