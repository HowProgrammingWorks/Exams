"use strict";

// Count words

const words = (str) => {
  let countOfWords = 0;
  let flag = false;
  for (const element of str) {
    if (flag === false && element !== " ") {
      flag = true;
      countOfWords++;
    }
    if (element === " ") flag = false;
  }
  return countOfWords;
};

const result = words("Hello Marcus Aureluis");
console.log(result);
