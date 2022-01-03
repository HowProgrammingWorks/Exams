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
    if (flag == true){flag = false;}else{flag = false;}
      } else{
    if (flag == true){flag = true;}else{flag = true;}
        numberofwordsinstr++;
     }
    } else {
    if (element == ' '){
      if (flag == true){ flag = false;}else{ flag = false;}
      } else {
        if (flag == true){flag = true; }else{flag = true; }
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