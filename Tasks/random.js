'use strict';

// Generate random integer value in given range

const random = (min, max = min) => {
  const res = min + Math.random() * (max - min + 1);
  return Math.floor(res);
};

require('../Tests/random.js')(random);
