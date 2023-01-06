// Return an array without duplicates

'use strict';

const DISTINCT = (data) => {
  console.log({ data });
  const A = new Set();
  let w = 0;
  data.forEach((a) => {
    if (A.has(a)) {
      delete data[w];
    } else {
      A.add(a);
    }
    w++;
  });
  return data.filter
  (x => typeof x === 'number');
};

require('../Tests/distinct.js')(DISTINCT);
