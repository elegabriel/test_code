#include "MD5.hpp"



// string changeHex(unsigned int a ){
//     string str = "";
//     unsigned char * tmp = (unsigned char*) &a;
//     unsigned int k;
//     for (int i = 0; i <4 ; i++) {
//         k = tmp[i];
//         str += char16[k>>4];
//         str += char16[k&0xf];
//     }
//     return str;
// }

int main(int argc, const char * argv[]){

  string s = "hello, world";
  cout<<s.find("hello")<<endl;
    
	// unsigned int i = 0x12345678;

	// cout<<changeHex(i)<<endl;
    // string ss;
    // cin>>ss;
    // string s = getMD5(ss);
    // cout<<s<<endl;
    return 0;
    
}
