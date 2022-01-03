'use strict';

// Count words

function words(str) {
  let countWords = 0;
  let flag = false;
  for (const char of str) {
    if (!flag) {
      char === ' ' ? flag = false : (flag = true, countWords++);
    } else {
      char === ' ' ? flag = false : flag = true;
    }
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
