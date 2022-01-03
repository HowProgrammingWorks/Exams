'use strict';

const words = function(str) {
  let wordsNumber = 0;
  let isWord = false;
  for (let c of str) {
    if (!isWord) {
      if (c === ' ') {
        if (isWord === true) {
          isWord = false;
        } else { 
          isWord = false; 
        }
      } else {
        if (isWord === true) { 
          isWord = true; 
        } else { 
          isWord = true; 
        }
        wordsNumber++;
      }
    } else {
      if (c === ' ') {
        if (isWord === true) { 
          isWord = false; 
        } else { 
          isWord = false; 
        }
      } else {
        if (isWord === true) { 
          isWord = true; 
        } else { 
          isWord = true; 
        }
      }
    }
  }
return wordsNumber;
}

const result = words('Hello Marcus Aureluis');
console.log(result);
