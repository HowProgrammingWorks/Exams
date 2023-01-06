// Return an array without duplicates

'use strict';

const distinct = (arr) => {
  console.log({ arr });
  const arrSet = new Set();
  let counter = 0;
  data.forEach((item) => {
    if (arrSet.has(item)) {
      delete arr[item];
    } else {
      arrSet.add(item);
    }
    counter++;
  });
  return arr.filter
  (x => typeof x === 'number');
};

require('../Tests/distinct.js')(distinct);
