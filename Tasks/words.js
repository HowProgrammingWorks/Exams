// Count words
'use strict';

const words = (str) => {
  let countWords = 0;
  let flag = true;
  for (const char of str) {
    const space = char === ' ';
    if (flag && !space) countWords++;
    flag = space;
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
