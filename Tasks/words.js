'use strict';

const words = function(str) {
  let wordsNumber = 0;
  let isWord = false;
  for (let c of str) {
    if (!isWord) {
      if (c !== ' ') {  
        isWord = true; 
        wordsNumber++;
      }
    } else {
      if (c === ' ') {
          isWord = false; 
      } else {  
        isWord = true; 
      }
    }
  }
return wordsNumber;
}

const result = words('Hello Marcus  Aureluis');
console.log(result);
