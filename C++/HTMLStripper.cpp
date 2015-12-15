#include <iostream>
using namespace std;
#include <string>
#include <fstream>
#include "require.h"
string replaceAll(string s, string f, string r){
  unsigned int found = s.find(f);
  while (found != string::npos) {
    s.replace(found, f.length(), r);
    found = s.find(f);
  }
  return s;
}

string stripHTMLTags(string s){
  while (true) {
    unsigned int left = s.find('<');
    unsigned int right = s.find('>');
    if (left == string::npos || right == string::npos)
    {
      break;
    }
    s = s.erase(left, right - left +1);
  }
  replaceAll(s, "&lt;", "<");
  replaceAll(s, "&gt;", ">");
  replaceAll(s, "&amp", "&");
  replaceAll(s, "&nbsp", " ");

  return s;
}

int main(int argc, char const *argv[]) {
  requireArgs(argc, 1, "usage: HTMLStrepper InputFile");
  ifstream in(argv[1]);
  assure(in, argv[1]);
  const int sz = 4096;
  char buf[sz];
  while (in.getline(buf, sz)) {
    string s(buf);
    cout<< stripHTMLTags(s)<<endl;
  }
  return 0;
}
