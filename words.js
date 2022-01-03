'use strict';

// Count words

const Words = function(str) {
  let wordsInString = 0;
  let checkForChar = true;
  for (const char of str) {
    if (checkForChar === true && char !== ' ') { 
        checkForChar = false;
        wordsInString++
    } else if (char === ' ') checkForChar = true;
  }
return wordsInString
}

const result = Words('Hello Marcus Aureluis');
console.log(result);