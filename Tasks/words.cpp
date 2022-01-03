#include <iostream>
#include <string>
using namespace std;
// Count words

const int words(const string str)
{
  int numberofwordsinstr = 0;
  bool flag = false;
  for (const char &element : str)
  {

    if (element == ' ')
    {
      flag = false;
    }
    else
    {
      if (!flag)
      {
        numberofwordsinstr++;
      }
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