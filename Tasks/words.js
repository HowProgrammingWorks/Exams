// Count words
'use strict';

const countWords = (str) => {
  let wordsNum = 0;
  let flag = false;
  for (const element of str) {
    if (flag === false && element !== ' ') {
      flag = true;
      wordsNum++;
    }
    if (element === ' ') {
      flag = false;
    }
  }
  return wordsNum;
};

const result = countWords('Hello Marcus Aureluis');
console.log(result);
