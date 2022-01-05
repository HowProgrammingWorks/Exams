// Count words
'use strict';

const countWords = function(line) {
  let numberOfWordsInLine = 0;
  let isNotSpace = true;
  for (const char of line) {
    if (isNotSpace && char !== ' ') {
      isNotSpace = false;
      numberOfWordsInLine++;
    } else {
      isNotSpace = (char === ' ');
    }
  }
  return numberOfWordsInLine;
};

const result = countWords('Hello Marcus Aureluis');
console.log(result);
