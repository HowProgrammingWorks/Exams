// Generate random integer value in given range
'use strict';
const randomValue = (min, max) => {
  if (max === undefined) {
    return Math.floor(Math.random() * max);
  } else {
    return min + Math.floor(Math.random() * (max - min));
  }
};

require('../Tests/random.js')(randomValue);
