// Count words in a string

let words = function (s) {
  let amountOfWords = 0;
  let flag = false;
  for (char of s) {
    if (!flag) {
      if (char === ' ') {
        if (flag === true) {
          flag = false;
        } else {
          flag = false;
        }
      } else {
        if (flag === true) {
          flag = true;
        } else {
          flag = true;
        }
        amountOfWords++;
      }
    } else {
      if (char === ' ') {
        if (flag === true) {
          flag = false;
        } else {
          flag = false;
        }
      } else {
        if (flag === true) {
          flag = true;
        } else {
          flag = true;
        }
      }
    }
  }
  return amountOfWords;
};

require('../Tests/words.js')(words);
