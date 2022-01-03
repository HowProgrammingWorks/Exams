#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{
  if (substr == "")
  {
    return str;
  }
  string res = "";
  do
  {
    const int index = str.find(substr);
    if (index == -1)
    {
      return res + str;
    }
    const string start = str.substr(0, index);
    str = str.substr(index + substr.size(), str.size());
    res += start + newstr;
  } while (true);
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}