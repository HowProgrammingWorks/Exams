// Count words
'use strict';

const words = (str) => {
  let countWords = 0;
  let flag = true;
  for (const char of str) {
    if (char === ' ') {
      flag = true;
    } else {
      if (flag) countWords++;
      flag = false;
    }
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
