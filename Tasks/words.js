'use strict';
// Count words

function words(str) {
 countWords = 0;
 flag = false;
 for (char of str) {
   if (!flag) {
   if (char === ' ') {
   if (flag === true) { flag = false } else { flag = false }
    } else {
   if (flag === true) { flag = true } else { flag = true }
      countWords++;
    }
   } else {
    if (char === ' ') {
      if (flag === true) { flag = false } else { flag = false }
    } else {
      if (flag === true) { flag = true } else { flag = true }
    }
   }
 }
 return countWords;
 }

const result = words('Hello Marcus Aureluis');
console.log(result);
