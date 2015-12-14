//
//  MD5.cpp
//  3D_Watermark
//
//  Created by ele on 12/8/15.
//  Copyright © 2015 ele. All rights reserved.
//

#include "MD5.hpp"

unsigned int strlength;
unsigned int aTmp;
unsigned int bTmp;
unsigned int cTmp;
unsigned int dTmp;

unsigned int* add(string str){
    unsigned int num =(unsigned int)((str.length() + 8)/64 + 1);
    unsigned int *strByte = new unsigned int[num*16];
    unsigned int i;
    
    strlength = num*16;
    for ( i = 0; i < num*16; i++) {
        strByte[i] = 0;
    }
    for ( i = 0; i < str.length(); i++) {
        strByte[i>>2] = str[i] << ((i%4)*8);
    }
    strByte[i>>2] |= 0x80<<((i%4)*8);
    return strByte;
}

string getMD5(string source){
    unsigned int i, j;
    unsigned int num[16];
    
    aTmp = A;
    bTmp = B;
    cTmp = C;
    dTmp = D;
    unsigned int * strByte = add(source);
    for (i = 0 ; i < strlength / 16; i++) {
        for (j =0 ; j < 16 ; j++ ) {
            num[j] = strByte[i*16+j];
        }
        mainLoop(num);
    }
    return changeHex(aTmp).append(changeHex(bTmp)).append(changeHex(cTmp)).append(changeHex(dTmp));
}

string changeHex(unsigned int a ){
    string str = "";
    char * tmp = (char*) &a;
    for (int i = 3; i >= 0 ; i--) {
        str += char16[(tmp[i]>>4)];
        str += char16[(tmp[i]&0xf)];
    }
    return str;
}

void mainLoop(unsigned int M[]){
    unsigned int f, g;
    unsigned int a = aTmp;
    unsigned int b = bTmp;
    unsigned int c = cTmp;
    unsigned int d = dTmp;
    
    for (unsigned int i = 0; i<64; i++) {
        if (i<16) {
            f = F(b, c, d);
            g = i;
        }
        else if (i<32){
            f = G(b, c, d);
            g = (5*i +1)%16;
        }
        else if (i<48){
            f = H(b, c, d);
            g = (3*i +1)%16;
        }
        else{
            f = I(b, c, d);
            g = (7*i)%16;
        }
        unsigned int tmp=d;
        d = c;
        c = b;
        b = b + CShift(a+f+k[i]+M[g], s[i]);
        a=tmp;
    }
}