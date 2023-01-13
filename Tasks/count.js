'use strict';

// Sum all number values in dict

const numberCounter = (obj) => {
  let result = 0;
  const keys = Object.keys(obj);
  for (const key of keys) {
    if (typeof obj[key] === 'number') result += obj[key];
  }
  return result;
};

require('../Tests/count.js')(numberCounter);

//Count is fixed (Passed: 6 of 6)
