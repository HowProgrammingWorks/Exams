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

const result = words('Hello Marcus Aureluis');
console.log(result);
