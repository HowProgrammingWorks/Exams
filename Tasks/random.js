// Generate random integer value in given range
'use strict'
const random = (min, max) => {
  if (max === undefined)  max = min;
  return Math.floor(Math.random() * (max - min + 1) + min)
};

require('../Tests/random.js')(random);
