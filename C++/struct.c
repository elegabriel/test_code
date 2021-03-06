#include <stdlib.h>
#include <stdio.h>

typedef struct Node node;
typedef node* PtrToNode; //ptr: pointer
typedef PtrToNode List;

struct Node
{
  int data;
  PtrToNode next;
};


int main()
{
  List head = (List) malloc(sizeof(node));
  if(!head) return 1;
  int num;
  PtrToNode p = head;
  while(scanf("%d",&num))
    {
      p->next = (List)malloc(sizeof(node));
      p=p->next;
      if(!p) return 1;
      p->data = num;
    }

  p=head->next;
  int i=1;
  while(p)
    {
      printf("%d : %d\n", i++,p->data);
      p=p->next;
    }
  return 0;
}
