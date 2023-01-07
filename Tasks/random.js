// Generate random integer value in given range
'use strict';

const random = (min, max) => {
  return min + Math.floor(Math.random() * (max - min + 1));
};

require('../Tests/random.js')(random);
