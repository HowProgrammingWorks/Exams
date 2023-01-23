'use strict';

// Sum all number values in dict

const countNumbers = (obj) => {
  let result = 0;
  const values = Object.values(obj);
  for (const value of values) {
    if (typeof value === 'number') result += value;
  }
  return result;
};

require('../Tests/count.js')(countNumbers);

//Count is fixed (Passed: 6 of 6)
