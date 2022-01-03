#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{
  const int positionofsubstr = str.find(substr),lengthofsubstr = substr.size();
  if (substr == "" || positionofsubstr == -1)
  {
    return str;
  }
  string strwithoutsubstr = str.erase(positionofsubstr, lengthofsubstr);
  const string result = strwithoutsubstr.insert(positionofsubstr, newstr);
  return result;
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;
}