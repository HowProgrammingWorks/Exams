'use strict';
// Count words in a string

const numOfWords = (words) => {
  let count = 0;
  let flag = false;

  for (const char of words) {
    if (!flag) {
      if (char !== ' ') {
        flag = true;
        count++;
      }
    } else if (char === ' ') {
      flag = false;
    }
  }

  return count;
};

require('../Tests/words.js')(numOfWords);
