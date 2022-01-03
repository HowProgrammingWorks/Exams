'use strict';

// Count words

const Words = function(str) {
  let wordsInString = 0;
  let charAfterSpace = true;
  for (const char of str) {
    if (charAfterSpace === true && char !== ' ') { 
        charAfterSpace = false;
        wordsInString++
      } else if (char === ' ') charAfterSpace = true;
  }
return wordsInString
}

const result = Words('Hello Marcus Aureluis');
console.log(result);