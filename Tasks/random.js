// Generate random integer value in given range
'use strict';

const random = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};

require('../Tests/random.js')(random);
