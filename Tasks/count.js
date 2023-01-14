'use strict';

// Sum all number values in dict

const countNumbers = (obj) => {
  let result = 0;
  const keys = Object.keys(obj);
  for (const key of keys) {
    if (typeof obj[key] === 'number') result += obj[key];
  }
  return result;
};

require('../Tests/count.js')(countNumbers);

//Count is fixed (Passed: 6 of 6)
