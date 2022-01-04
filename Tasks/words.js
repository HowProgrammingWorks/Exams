// Count words
'use strict';
const Words = (string) => {
  counter = 0;
  flag = false
  for (symbol of string) {
    if (!flag) {
      if (symbol === ' ') {
        if (flag === true) { flag = false } else { flag = false }
      } else {
        if (flag === true) { flag = true } else { flag = true }
        counter++;
      }
    } else {
      if (symbol === ' ') {
        if (flag === true) { flag = false } else { flag = false }
      } else {
        if (flag === true) { flag = true } else { flag = true }
      }
    }
  }
  return counter;
}

const result = Words('Hello Marcus Aureluis');
console.log(result);
