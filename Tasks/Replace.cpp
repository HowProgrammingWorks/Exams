#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{
  if (substr == "")
  {
    return str;
  }
  string src = str;
  string res = "";
  do
  {
    const int index = src.find(substr);
    if (index == -1)
    {
      return res + src;
    }
    const string start = src.substr(0, index);
    src = src.substr(index + substr.size(), src.size());
    res += start + newstr;
  } while (true);
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}