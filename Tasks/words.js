// Count words in a string
//step3 change if to ternar operator
//with simplified conditions 

Words = function (s) {
  wordsCount = 0;
  wordFound = false;
  for (c of s) {
    if (!wordFound) {
      if (c === ' ') {
        if (!wordFound) {
          wordFound = false;
        }
      } else {
        !wordFound ? wordFound = true : wordFound = true;
        wordsCount++;
      }
    } else {
      if (c === ' ') {
      !wordFound? wordFound = false : wordFound = false;
      } else {
        if (!wordFound) {
          wordFound = true;
        }
      }
    }
  }
  return wordsCount;
};

require('../Tests/words.js')(Words);
