'use strict';

const words = (str) => {
  let wordsNumber = 0;
  let isWord = false;
  for (const element of str) {
    if (!isWord && element !== ' ') {
      isWord = true;
      wordsNumber++;
    } else if (isWord && element === ' ') {
      isWord = false;
    }
  }
  return wordsNumber;
};

const result = words('Hello Marcus Aureluis');
console.log(result);
