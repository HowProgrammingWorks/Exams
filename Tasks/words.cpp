#include <iostream>
#include <string>
using namespace std;
// Count words

int words(string str)
{
  int numberofwordsinstr = 0;
  bool flag = false;
  for (char element : str)
  {

    if (element == ' ')
    {
      flag = false;
    }
    else if (!flag)
    {
      flag = true;
      numberofwordsinstr++;
    }
    else
    {
      flag = true;
    }
  }
  return numberofwordsinstr;
}
int main()
{
  const int result = words("Hello Marcus Aureluis");
  cout << result;
  return 0;
}