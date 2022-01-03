#include <iostream>
#include <string>
using namespace std;
string replace(string str = "", string substr = "", string newstr = "")
{
  if (substr == ""){
    return str;
  }else{
    string src=str;
    string res="";
    do{
      const int _index=src.find(substr);
      if (_index == -1){ return res + src;}else{ 
        const string start = src.substr(0, _index);
        src = src.substr(_index + substr.size(), src.size());
        res += start + newstr;
      }} while (true);}}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}