#include <iostream>
#include <string>
using namespace std;
// Count words

int words(string str)
{
  int numberofwordsinstr = 0;
  bool flag = false;
  for (char element : str){
    if (!flag){
    if (element == ' '){
      flag = false;
      } else{
      flag = true;
        numberofwordsinstr++;
     }
    } else {
    if (element == ' '){
      flag = false;
      } else {
      flag = true;
      }
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