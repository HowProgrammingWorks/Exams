// Count words
'use strict';

const wordsCounter = (str) => {
  let wordsInStr = 0;
  let startOfWord = true;

  for (const char of str) {
    if (startOfWord && char !== ' ') {
      startOfWord = false;
      wordsInStr++;
    } else {
      startOfWord = (char === ' ');
    }
  }
  return wordsInStr;
};

const result = wordsCounter('Hello, Saint Marcus, wish me good luck and conjure me 100 points');
console.log(result);
