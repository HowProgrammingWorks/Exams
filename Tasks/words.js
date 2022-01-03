'use strict';

// Count words

const words = (string) => {
  let numberOfWords = 0
  let flag = false
  for (const element of string) {
    if (!flag) {
      if (element === ' ') {
        if (flag === true) { flag = false } else { flag = false }
      } else {
        if (flag === true) { flag = true } else { flag = true }
        numberOfWords++
      }
    } else {
      if (element === ' ') {
        if (flag === true) { flag = false } else { flag = false }
      } else {
        if (flag === true) { flag = true } else { flag = true }
      }
    }
  }
  return numberOfWords
}

const result = words('Hello Marcus Aureluis');
console.log(result);
