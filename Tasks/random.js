// Generate random integer value in given range
'use strict';

const randomInteger = (min, max) => {
  if (min === undefined && max === undefined) {
    return 'Enter the data correctly!';
  }
  if (max === undefined) {
    max = min;
    return Math.floor(Math.random() * (max + 1));
  }

  const randomNumber = min + Math.random() * (max + 1 - min);
  return Math.floor(randomNumber);
};

const result = randomInteger(1, 9);
console.log(result);
