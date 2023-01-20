// Count words in a string
//step5 simplify code(put main function in one "for")
//add 'use strict' and change to arrow function
const words = (s) => {
  let wordsCount = 0;
  let wordFound = false;
  for (let i = 0; i < s.length; i++) {
    if (s[i] === ' ') {
        wordFound = false;
    } else if (!inWord) {
        wordsCount++;
        wordFound = true;
    }
  }
  return wordsCount;
};

require('../Tests/words.js')(words);
