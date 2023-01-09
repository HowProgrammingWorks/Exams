'use strict';
// Generate random integer value in given range

const random = (min, max) => {
  const correctionInt = 1;
  if (!max) {
    const randomFloat = Math.random() * (min + correctionInt);
    return Math.floor(randomFloat);
  }
  const randomFloat = min + Math.random() * (max - min + correctionInt);
  return Math.floor(randomFloat);
};

require('../Tests/random.js')(random);
