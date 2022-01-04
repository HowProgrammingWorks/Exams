// Count words
'use strict';
const Words = (string) => {
  let counter = 0;
  let flag = false;
  for (symbol of string) {
    if (!flag) {
      if (symbol === ' ') {
        { flag = false };
      }
       else {
        { flag = true };
        counter++;
      }
    } else {
      if (symbol === ' ') {
        { flag = false };
      } else {
        { flag = true };
      }
    }
  }
  return counter;
}

const result = Words('Hello Marcus Aureluis');
console.log(result);
