// Count words
'use strict';

const words = (str) => {
  let countWords = 0;
  let flag = true;
  for (const char of str) {
    const space = char === ' '; 
    if (space) {
      flag = space;
    } else {
      if (flag) countWords++;
      flag = space;
    }
  }
  return countWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
