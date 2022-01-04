// Count words
"use strict";

const countWords = function (str) {
  let wordsNum = 0;
  let flag = false;
  for (const element of str) {
    if (!flag) {
      if (element === " ") {
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
        wordsNum++;
      }
    } else {
      if (element === " ") {
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
  return wordsNum;
};

const result = countWords("Hello Marcus Aureluis");
console.log(result);
