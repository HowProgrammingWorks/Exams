'use strict';

// Sum all number values in dict

const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    if (typeof obj[key] === 'number') sum += obj[key];
  });
  return sum;
};

require('../Tests/count.js')(count);
