// Count words in a string

Words = function (s) {
  numberOfWords = 0;
  inWord = false;
  for (c of s) {
    if (!inWord) {
      if (c === ' ') {
      } else {
        !inWord ? inWord = true : inWord = true;
        numberOfWords++;
      }
    } else {
      if (c === ' ') {
        !inWord ? inWord = false : inWord = false;
      }
    }
  }
  return numberOfWords;
};

require('../Tests/words.js')(Words);