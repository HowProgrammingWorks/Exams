'use strict';
// Count words in a string

const numOfWords = (words) => {
  let count = 0;
  let isNewWord = true;

  for (const char of words) {
    if (char === ' ') {
      isNewWord = true;
    }

    if (isNewWord && char !== ' ') {
      isNewWord = false;
      count++;
    }
  }

  return count;
};

require('../Tests/words.js')(numOfWords);
