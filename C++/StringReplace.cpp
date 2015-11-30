#include <string>
#include <iostream>
using namespace std;

int main(){
  string s("A piece of text");
  string tag("$tag$");
  s.insert(8, tag+' ');
  cout<<s<<endl;
  int start =s.find(tag);
  cout<<"s = "<<s<<endl;
  cout<<"start = "<<start<<endl;
  cout<<"size = "<<tag.size()<<endl;
  s.replace(start, tag.size(),"hello there");
  cout<<s<<endl;
  return 0;
}

 
