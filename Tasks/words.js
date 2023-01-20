// Count words in a string
//step6 change if, else if to ternar operator
const words = (s) => {
  let wordsCount = 0;
  let wordFound = false;
  for (let i = 0; i < s.length; i++) {
    s[i] === ' ' ? inWord = false : !inWord ? wordsCount++ : null;
    wordFound = true;
    }
  }
  return wordsCount;
};

require('../Tests/words.js')(words);
