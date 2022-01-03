'use strict';

// Count words

const Words = function(str) {
  let number_of_words_in_s = 0;
  let flag = false;
  for ( let char of str) {
    if (!flag) {
      if (char !== ' ') { 
        flag = true;
        number_of_words_in_s++
      }
    } else {
      if (char === ' ') flag = false;
    }
  }
return number_of_words_in_s
}

const result = Words('Hello Marcus Aureluis');
console.log(result);