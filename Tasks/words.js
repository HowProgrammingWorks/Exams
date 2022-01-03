// Count words
'use strict';

const wordsCounter = (str) => {
  let wordsInStr = 0;
  let flag = false;
  for (const char of str) {
    if (!flag) {
      if (char === ' ') {
        flag = false;
      } else {
        flag = true;
        wordsInStr++;
      }
    } else if (char === ' ') {
      flag = false;
    } 
  }
  return wordsInStr;
};

const result = wordsCounter('Hello Marcus Aureluis');
console.log(result);
