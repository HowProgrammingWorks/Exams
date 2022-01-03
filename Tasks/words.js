'use strict';

// Count words

const words = (string) => {
  let numberOfWords = 0;
  let flag = false;
  for (const element of string) {
    if (flag === false && element !== ' ') {
      flag = true;
      numberOfWords++;
    }
    if (element === ' ') {
      flag = false;
    }
  }
  return numberOfWords;
}

const str = 'Hello Marcus Aureluis';
const result = words(str);
console.log(result);
