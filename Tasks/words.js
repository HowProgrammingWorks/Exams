'use strict';
// Count words

const words = string => {
 const arrOfWords = string.split(" ");
 let numberOfWords = 0
 for (const element of arrOfWords) {
   numberOfWords++;
 }
 return numberOfWords;
}

const result = Words('Hello Marcus Aureluis');
console.log(result);
