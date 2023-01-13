// Count words in a string

Words = function (s) {
  numberOfWords = 0;
  inWord = false;
  for (c of s) {
    if (!inWord) {
      if (c === ' ') {
        if (!inWord) {
          inWord = false;
        }
      } else {
        !inWord ? inWord = true : inWord = true;
        numberOfWords++;
      }
    } else {
      if (c === ' ') {
        !inWord ? inWord = false : inWord = false;
      } else {
        if (!inWord) {
          inWord = true;
        }
      }
    }
  }
  return numberOfWords;
};

require('../Tests/words.js')(Words);