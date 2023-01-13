// Count words in a string

Words = function (s) {
  numberOfWords = 0;
  inWord = false;
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

require('../Tests/words.js')(Words);