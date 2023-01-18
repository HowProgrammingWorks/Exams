// Count words in a string

//Step 3
//Use ternary operator instead of if-statements
//Remove useless `else`

'use strict';

const Words = function (s) {
  let number_of_words_in_s = 0;
  let flag = false;
  for (const c of s) {
    if (!flag) {
      c === ' ' ? flag = false : flag = true;
        number_of_words_in_s++;
      }
      c === ' ' ? flag = false : flag = true; 
    }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
