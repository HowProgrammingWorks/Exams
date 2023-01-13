// Count words in a string
'use strict';

const words = (s) => {
  let numberOfWords = 0;
  let inWord = false;
  for (let i = 0; i < s.length; i++) {
    if (s[i] === ' ') {
        inWord = false;
    } else if (!inWord) {
        numberOfWords++;
        inWord = true;
    }
  }
  return numberOfWords;
};

require('../Tests/words.js')(words);