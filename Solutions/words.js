'use strict'

const Words = (s) => {
  let number_of_words_in_s = 0;
  let flag = false;
  for (const c of s) {
    if (!flag && c !== ' ') {
        flag = true;
        number_of_words_in_s++;
    } else if (c === ' ') {
          flag = false;
      }
  }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
