
#include <stdlib.h>
#include <stdio.h>

void ChangString();
int Manacher();

const int MAX = 1000000;

char s[MAX+1];
char sc[MAX*2+1];
int p [MAX];

int main(int argc, const char * argv[]) {
    // insert code here...
    int num;
    
    if (!scanf("%d", &num)) {
        return 0;
    }
    while (num--) {
        scanf("%s",s);
        ChangString();
        printf("%d\n",Manacher());
    }
    return 0;
}

void ChangString(){
    int i;
    for (i=0; s[i]; i++) {
        sc[i*2]='#';
        sc[i*2+1]=s[i];
    }
    sc[i*2]='#';
    sc[i*2+1]='\0';
}

int Manacher()
{
    int ans, id, maxid, i;
    id = maxid = 0;
    ans =1;
    
    for (i=0; sc[i]; i++) {
        if (maxid >i) {
            p[i] = (p[id*2-i]>maxid-i)?(maxid-i):(p[id*2-i]);
        }
        else
            p[i] = 1;
        
        while (i-p[i]>=0 && sc[i+p[i]] && sc[i-p[i]] == sc[i+p[i]]) {
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