// Return an array without duplicates

// Distinct is fixed. Test is passed: 9 of 9

'use strict';

const distinct = (arr) => {
  const res = [];
  for (const item of arr) {
    if (!res.includes(item)) {
      res.push(item);
    }
  }
  return res;
};

require('../Tests/distinct.js')(distinct);
