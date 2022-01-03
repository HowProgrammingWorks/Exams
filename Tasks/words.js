// Count words
'use strict';

const wordsCounter = (str) => {
  let wordsInStr = 0;
  let startOfWord = true;
  for (const char of str) {
    if (startOfWord && char !== ' ') {
      startOfWord = false;
      wordsInStr++;
    } else if (char === ' ') {
      startOfWord = true;
    }
  }
  return wordsInStr;
};

const result = wordsCounter('Hello Marcus Aureluis');
console.log(result);
