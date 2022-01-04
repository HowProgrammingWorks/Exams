'use strict';

// Count words

const words = (string) => {
  let numberOfWords = 0;
  let flag = false;
  for (const char of string) {
    if (flag === false && char !== ' ') {
      flag = true;
      numberOfWords++;
    }
    if (char === ' ') {
      flag = false;
    }
  }
  return numberOfWords;
};

const str = 'Hello Marcus Aureluis';
const result = words(str);
console.log(result);
