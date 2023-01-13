'use strict';

// Sum all number values in dict

const count = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  for (const item of values) {
    if (typeof item === 'number') sum += item;
  }
  return sum;
};

require('../Tests/count.js')(count);
