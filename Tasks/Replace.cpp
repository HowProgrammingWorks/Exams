#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{const int positionofsubstr = str.find(substr);
  if (substr == "")
  {
    return str;
  }
  string res = "";
  do
  {
    if (positionofsubstr == -1)
    {
      return res + str;
    }
    const string start = str.substr(0, positionofsubstr);
    str = str.substr(positionofsubstr + substr.size(), str.size());
    res += start + newstr;
  } while (true);
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}