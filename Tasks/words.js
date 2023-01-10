// Count words in a string

'use strict';

const words = (string) => {
  if (string === '') {
    return 0;
  }
  let wordsAmount = 1;
  for (const char of string) {
    if (char === ' ') {
      wordsAmount++;
    }
  }
  return wordsAmount;
};

require('../Tests/words.js')(words);
