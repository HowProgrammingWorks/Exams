// Count words in a string

let words = function (s) {
  let amountOfWords = 0;
  let flag = false;
  for (char of s) {
    if (!flag) {
      if (char === ' ') {
        flag = false;
      } else {
        flag = true;
        }
        amountOfWords++;
      }
     else {
      if (char === ' ') {
        flag = false;
      } else {
          flag = true;
        }
      }
    }
    return amountOfWords;
  };

require('../Tests/words.js')(words);
