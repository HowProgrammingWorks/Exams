// Count words in a string
//step4 remove useless things(if)

Words = function (s) {
  wordsCount = 0;
  wordFound = false;
  for (c of s) {
    if (!wordFound) {
      if (c === ' ') {
      } else {
        !wordFound ? wordFound = true : wordFound = true;
        wordsCount++;
      }
    } else {
      if (c === ' ') {
      !wordFound? wordFound = false : wordFound = false;
      }
    }
  }
  return wordsCount;
};

require('../Tests/words.js')(Words);
