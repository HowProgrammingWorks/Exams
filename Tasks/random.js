'use strict';
// Generate random integer value in given range

const random = (min, max) => {
  const multiplier = max ? (max - min + 1) : (min + 1);
  const summand = max ? min : 0;
  return summand + Math.floor(Math.random() * multiplier);
};
