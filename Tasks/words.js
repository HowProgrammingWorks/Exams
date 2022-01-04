'use strict';
// Count words

const words = (string) => {
 const arrOfWords = string.split(" ");
 const numberOfWords = arrOfWords.length;
 return numberOfWords;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
