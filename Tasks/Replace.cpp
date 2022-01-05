#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{
  if (substr == "") return str;
  const int positionofsubstr = str.find(substr);

  return str.erase(positionofsubstr, substr.size()).insert(positionofsubstr, newstr);
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}