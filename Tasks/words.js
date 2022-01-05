// Count words
"use strict";
const Words = (string) => {
  let counter = 0;
  let flag = false;
  for (const symbol of string) {
    if (!flag && symbol !== " ") {
      {
        flag = true;
      }
      counter++;
    } else if (flag && symbol === " ") {
      flag = false;
    }
  }
  return counter;
};

const result = Words("Hello Marcus Aureluis");
console.log(result);
