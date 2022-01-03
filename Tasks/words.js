// Count words
'use strict';

const wordsCounter = (str) => {
  let wordsInStr = 0;
  let flag = true;
  for (const char of str) {
    if (flag && char !== ' ') {
      flag = false;
      wordsInStr++;
    } else if (char === ' ') {
      flag = true;
    }
  }
  return wordsInStr;
};

const result = wordsCounter('Hello Marcus Aureluis');
console.log(result);
