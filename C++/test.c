#include <stdlib.h>
#include <stdio.h>
int main()
{
  const int bufiz;
  const int bufsize =100;
  char buf[bufsize];
  for (int i=0;i<bufsize;i++)
    {
      buf[i]=i;
      printf("%d : %d\n",i,buf[i]);
    }

  return 0;
}
