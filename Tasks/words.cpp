#include <iostream>
#include <string>
using namespace std;
// Count words

int Words(string s)
{
  int number_of_words_in_s = 0;
  bool flag = false;
  for (char c : s){
    if (!flag){
    if (c == ' '){
    if (flag == true){flag = false;}else{flag = false;}
      } else{
    if (flag == true){flag = true;}else{flag = true;}
        number_of_words_in_s++;
     }
    } else {
    if (c == ' '){
      if (flag == true){ flag = false;}else{ flag = false;}
      } else {
        if (flag == true){flag = true; }else{flag = true; }
      }
    }
  }
  return number_of_words_in_s;
}
int main()
{
  const int result = Words("Hello Marcus Aureluis");
  cout << result;
  return 0;
}