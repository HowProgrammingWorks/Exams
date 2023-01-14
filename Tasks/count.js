'use strict';

// Sum all number values in dict
const count = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  values.forEach((value) => {
    if (typeof value === 'number')
      sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
