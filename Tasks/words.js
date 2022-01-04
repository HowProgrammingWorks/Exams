// Count words
'use strict';

const words = (str) => {
 let countWords = 0
 let flag = false
 for (const char of str) {
   if (!flag) {
   if (char === ' ') {
   if (flag === true) { flag = false } else { flag = false }
    } else {
   if (flag === true) { flag = true } else { flag = true }
      countWords++
    }
   } else {
    if (char === ' ') {
      if (flag === true) { flag = false } else { flag = false }
    } else {
      if (flag === true) { flag = true } else { flag = true }
    }
   }
 }
 return countWords
 }

const result = words('Hello Marcus Aureluis');
console.log(result);
