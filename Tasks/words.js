'use strict';

// Count words

function words(str) {
  let countWords = 0;
  let flag = false;
  for (const char of str) {
    if (!flag) {
      if (char === ' ') {
        flag = false;
      } else {
        flag = true;
        countWords++;
      }
    } else if (char === ' ') {
      flag = false;
    } else {
      flag = true;
    }
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
