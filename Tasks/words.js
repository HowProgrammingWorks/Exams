'use strict'

// Count words

const words = function(str) {
  let countOfWords = 0;
  let flag = false;
  for (let element of str) {
    if (!flag) {
      if (element === ' ') {
        flag = false; 
      } else {
        flag = true; 
      }
      countOfWords++;
    } else {
      if (element === ' ') {
        flag = false;
      } else { 
        flag = true;
      }
    }
  }
  return countOfWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
