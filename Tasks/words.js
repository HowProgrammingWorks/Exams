// Count words
'use strict';

const wordsCounter = (str) => {
  let number_of_words_in_s = 0;
  let flag = false;
  for (const c of str) {
    if (!flag) {
      if (c === ' ') {
        if (flag === true) { flag = false; } else { flag = false; }
      } else {
        if (flag === true) { flag = true; } else { flag = true; }
        number_of_words_in_s++;
      }
    } else if (c === ' ') {
      if (flag === true) { flag = false; } else { flag = false; }
    } else if (flag === true) { flag = true; } else { flag = true; }
  }
  return number_of_words_in_s;
};

const result = wordsCounter('Hello Marcus Aureluis');
console.log(result);
