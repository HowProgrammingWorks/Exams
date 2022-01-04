'use strict';
// Generate random integer value in given range

const random = (min, max) => {
  if (!max) {
    max = min;
    min = 0;
  }
  const multiplier = max - min + 1;
  return min + Math.floor(Math.random() * multiplier);
};

const result = random(1, 9);
console.log(result);
