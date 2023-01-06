'use strict';
// Count words in a string

const numOfWords = (words) => {
  let count = 0;
  let isNewWord = true;

  for (const char of words) {
    if (isNewWord) {
      if (char !== ' ') {
        isNewWord = false;
        count++;
      }
    } else if (char === ' ') {
      isNewWord = true;
    }
  }

  return count;
};

require('../Tests/words.js')(numOfWords);
