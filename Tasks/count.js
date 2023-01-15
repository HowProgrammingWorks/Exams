// Sum all number values in dict
'use strict';

const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  keys.map((key) => {
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
