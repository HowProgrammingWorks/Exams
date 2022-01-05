#include <iostream>
#include <string>
using namespace std;
const string replace(string str = "", const string substr = "", const string newstr = "")
{
  const int positionofsubstr = str.find(substr);
  if (substr == "" || positionofsubstr == -1)
  {
    return str;
  }
  return str.erase(positionofsubstr, substr.size()).insert(positionofsubstr, newstr);
  
}
int main()
{
  cout << replace("Hello <username> and bye!", "<username>", "Marcus");
  return 0;

}