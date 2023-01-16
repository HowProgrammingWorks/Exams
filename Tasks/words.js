// Count words in a string

Words = function (s) {
  let countOfWords = 0;
  flag = false;
  for (c of s) {
    if (!flag) {
      if (c === ' '); 
      else {
        flag = true;
        countOfWords++;
      }
    } else {
      if (c === ' ') {
        flag = false
      } 
    }
  }
  return countOfWords;
};

require('../Tests/words.js')(Words);
