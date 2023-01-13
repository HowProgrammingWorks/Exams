'use strict'

const Words = function (s) {
  let number_of_words_in_s = 0;
  let flag = false;
  for (const c of s) {
    if (!flag) {
      if (c !== ' ') {
          flag = true;
        number_of_words_in_s++;
      }
    } else {
      if (c === ' ') {
          flag = false;
      } else flag = true;
    }
  }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
