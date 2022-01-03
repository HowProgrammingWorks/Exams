'use strict';

// Count words

const words = (string) => {
  let numberOfWords = 0;
  let flag = false;
  for (const element of string) {
    if (!flag) {
      if (element === ' ') {
          flag = false;
      } else {
          flag = true;
        }
      numberOfWords++;
    } else {
        if (element === ' ') {
          flag = false;
        } else {
          flag = true;
        }
      }
  }
  return numberOfWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
