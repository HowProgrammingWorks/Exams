// Count words
"use strict";

const countWords = (str) => {
  let wordsNum = 0;
  let flag = false;
  for (const element of str) {
    if (!flag) {
      if (element === " ") {
        flag = false;
      } else {
        flag = true;
      }
      wordsNum++;
    } else {
      if (element === " ") {
        flag = false;
      } else {
        flag = true;
      }
    }
  }
  return wordsNum;
};

const result = countWords("Hello Marcus Aureluis");
console.log(result);
