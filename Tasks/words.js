// Count words
'use strict';

const words = (str) => {
  let countWords = 0;
  let flag = false;
  for (const char of str) {
    if (char === ' ') {
      flag = false;
    } else {
      if (!flag) countWords++;
      flag = true;
    }
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
