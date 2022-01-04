'use strict'

// Count words

const words = function(str) {
  let countOfWords = 0;
  let flag = false;
  for (let element of str) {
    if (flag=== false && element !== ' ') {
        flag = true; 
        countOfWords++;
    }
    if (element === ' ') {
      flag = false;
    }
  }
  return countOfWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
