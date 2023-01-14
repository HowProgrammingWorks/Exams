// Return an array without duplicates
"use strict";

const distinct = (array) => {
  console.log({ array });
  A = new Set();
  w = 0;
  array.forEach((a) => {
    if (A.has(a)) {
      delete array[w];
    } else {
      A.add(a);
    }
    w++;
  });
  return array.filter
  (x => typeof x === 'number');
};

require('../Tests/distinct.js')(distinct);