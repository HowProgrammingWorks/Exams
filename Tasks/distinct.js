// Return an array without duplicates

'use strict';

const distinct = (arr) => {
  const res = [];
  arr.forEach((item) => {
    if (!res.includes(item)) {
      res.push(item);
    }
  });
  return res;
};

require('../Tests/distinct.js')(distinct);
