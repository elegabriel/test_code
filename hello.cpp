#include <iostream>

int main(){
	long *p;
	p = new (long);
	*p =(long) (p+10);
	std::cout<<sizeof(p)<<std::endl;
	long k = *(long *)(*p);
	
	std::cout<<k;
	return 0;
}