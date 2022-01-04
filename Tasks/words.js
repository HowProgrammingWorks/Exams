'use strict';

// Count words

const words = (str) => {
  let countWords = 0;
  let flag = false;
  for (const char of str) {
    if (!flag && char !== ' ') {
      countWords++;
    }
    //  flag = char === ' ' ? false : true;
    if (char === ' ') {
      flag = false;
    } else {
      flag = true;
    }
  }
  return countWords;
};

const result = words('Hello Marcus Aureluis');
console.log(result);
