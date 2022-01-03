'use strict';
// Count words

function words(str) {
 let countWords = 0;
 let flag = false;
 for (const char of str) {
   if (!flag) {
     if (char === ' ') {
        flag = flag === true ? flag = false : false;
    } else {
        flag = flag === true ? flag = true : true;
        countWords++;
    }
   } else if (char === ' ') {
    flag = flag === true ? flag = false : false;
    } else {
      flag = flag === true ? flag = true : true;
    }
   }
   return countWords;
 }

const result = words('Hello Marcus Aureluis');
console.log(result);
