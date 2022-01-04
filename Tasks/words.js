// Count words
'use strict'

 let countWords = function(line) {
 let numberOfWordsInLine = 0
 let isNotSpace = false
 for (let char of line) {
   if (!isNotSpace) {
   if (char === ' ') {
   if (isNotSpace === true) { isNotSpace = false } else { isNotSpace = false }
    } else {
   if (isNotSpace === true) { isNotSpace = true } else { isNotSpace = true }
   numberOfWordsInLine++
    }
   } else {
    if (char === ' ') {
      if (isNotSpace === true) { isNotSpace = false } else { isNotSpace = false }
    } else {
      if (isNotSpace === true) { isNotSpace = true } else { isNotSpace = true }
    }
   }
 }
 return numberOfWordsInLine
 }

const result = countWords('Hello Marcus Aureluis');
console.log(result);
