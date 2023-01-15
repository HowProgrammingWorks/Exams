// Count words in a string

Words = function (s) {
  countOfWords = 0;
  flag = false;
  for (c of s) {
    if (!flag) {
      if (c === ' ') {
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
        countOfWords++;
      }
    } else {
      if (c === ' ') {
        flag === true
      } else {
        flag = true;
      }
    }
  }
  return countOfWords;
};

require('../Tests/words.js')(Words);
