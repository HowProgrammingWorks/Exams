// Count words in a string

'use strict';

const Words = (s) => {
  if (s === '') {
    return 0;
  }
  let number_of_words_in_s = 1;
  for (const c of s) {
    if (c === ' ') {
      number_of_words_in_s++;
    }
  }
  return number_of_words_in_s;
};

require('../Tests/words.js')(Words);
