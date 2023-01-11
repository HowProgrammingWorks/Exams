// Count words in a string

'use strict';

const words = (string) => {
  const clearString = string.trim();
  if (clearString === '') {
    return 0;
  }
  let wordsAmount = 1;
  for (const char of clearString) {
    if (char === ' ') {
      wordsAmount++;
    }
  }
  return wordsAmount;
};

require('../Tests/words.js')(words);
