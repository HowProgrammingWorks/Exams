'use strict'

// Count words

words = function(str) {
  countOfWords = 0;
  flag = false;
  for ( element of str) {
    if (!flag) {
      if (element === ' ') {
        if (flag === true) {
          flag = false; 
        } else {
          flag = false;
        }
      } else {
        if (flag === true) { 
          flag = true; 
        } else { 
          flag = true; 
        }
        countOfWords++;
      }
    } else {
      if (element === ' ') {
        if (flag === true) { 
          flag = false; 
        } else { 
          flag = false;
        }
      } else {
        if (flag === true) {
          flag = true; 
        } else { 
        flag = true;
        }
      }
    }
  }
  return countOfWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
