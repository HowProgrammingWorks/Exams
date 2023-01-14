// Return an array without duplicates
'use strict';

const deduplicate = arr => {
  const set = new Set();
  let index = 0;
  arr.forEach((value) => {
    if (set.has(value)) {
      arr.splice(index, 1);
    }
    else {
      A.add(a);
    };
    w++;
  });
  return data;
}

require('../Tests/distinct.js')(deduplicate);
