// Count words in a string
//step2 change names

Words = function (s) {
  wordsCount = 0;
  wordFound = false;
  for (c of s) {
    if (!wordFound) {
      if (c === ' ') {
        if (wordFound === true) {
          wordFound = false;
        }
      } else {
        if (wordFound === true) {
          wordFound = true;
        } else {
          wordFound = true;
        }
        wordsCount++;
      }
    } else {
      if (c === ' ') {
        if (wordFound === true) {
          wordFound = false;
        } else {
          wordFound = false;
        }
      } else {
        if (wordFound === true) {
          wordFound = true;
        }
      }
    }
  }
  return wordsCount;
};

require('../Tests/words.js')(Words);
