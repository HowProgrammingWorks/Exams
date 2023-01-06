// Return an array without duplicates

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
