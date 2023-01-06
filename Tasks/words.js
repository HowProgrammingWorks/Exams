'use strict';
// Count words in a string

const numOfWords = function (words) {
  let count = 0;
  let flag = false;
  for (const word of words.split(' ')) {
    if (!flag) {
      if (word === ' ') {
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
        count++;
      }
    } else {
      if (word === ' ') {
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
  return count;
};

require('../Tests/words.js')(numOfWords);
