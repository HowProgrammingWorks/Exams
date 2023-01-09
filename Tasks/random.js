'use strict';
// Generate random integer value in given range

const random = (min, max) => {
  if (!max) {
    const randomFloat = Math.random() * (min + 1);
    return Math.floor(randomFloat);
  }
  const randomFloat = min + Math.random() * (max - min + 1);
  return Math.floor(randomFloat);
};

require('../Tests/random.js')(random);
