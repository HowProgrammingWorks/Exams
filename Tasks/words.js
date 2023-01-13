'use strict';

// Count words in a string

const words = str => {
  let amountOfWords = 0;
  let charDetected = false;
  for (const char of str) {
    if (!charDetected && char !== ' ') {
      charDetected = true;
      amountOfWords++;
    } else if (char === ' ') {
      charDetected = false;
    }
  }
  return amountOfWords;
};

require('../Tests/words.js')(words);
