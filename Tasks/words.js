// Count words in a string

Words = function (s) {
  numberOfWords = 0;
  inWord = false;
  for (c of s) {
    if (!inWord) {
      if (c === ' ') {
        if (inWord === true) {
          inWord = false;
        }
      } else {
        inWord === true ? inWord = true : inWord = true;
        numberOfWords++;
      }
    } else {
      if (c === ' ') {
        inWord === true ? inWord = false : inWord = false;
      } else {
        if (inWord === true) {
          inWord = true;
        }
      }
    }
  }
  return numberOfWords;
};

require('../Tests/words.js')(Words);