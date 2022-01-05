#include <iostream>
#include <string>
using namespace std;
// Count words

const int words(const string str)
{
  int numberofwordsinstr = 0;
  for (unsigned int index=0; index < str.size(); ++index)
  {
      if ((str[index + 1] != ' ' && str[index + 1] != '\0') && str[index] == ' ')
      numberofwordsinstr++;
  }
  return numberofwordsinstr;
}
int main()
{
  const int result = words("Hello Marcus Aureluis");
  cout << result;
  return 0;
}