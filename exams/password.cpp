#include <iostream>
#include<ctime>
using namespace std;
const char alphabet[] = "0123456789!@#$%^&*()qwertyuiop[]asdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
const int string_length = sizeof(alphabet) ;
int main()
{
    srand(time(NULL));
    int n;
    cout<<"Enter the length of your password:";
    cin>>n;
    cout<<"Generated random password:";
    for(int i = 0; i < n; i++)
        cout << alphabet[rand() % string_length];
}