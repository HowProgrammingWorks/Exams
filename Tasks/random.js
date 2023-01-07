'use strict';
// Generate random integer value in given range

const Random = (min, max) => {
  if (max === undefined) {
    max = min;
    return Math.floor(Math.random() * (max + 1));
  } else {
    return min + Math.floor(Math.random() * (max - min + 1));
  }
};

require('../Tests/random.js')(Random);
