'use strict';
// Count words

const words = string => {
 let numberOfWords = 0
 let isLetter = false
 for (const element of string) {
   if (!isLetter) {
    if (element !== ' ') {
     isLetter = true; 
     numberOfWords++;
    }
   } else {
    if (element === ' ')  isLetter = false;
   }
 }
 return numberOfWords;
}

const result = Words('Hello Marcus Aureluis');
console.log(result);
