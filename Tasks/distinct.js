'use strict';

// Deduplicate values in array

const distinctValues = (data) => {
  const col = new Set();
  let w = 0;
  for (const item of data) {
    col.add(item);
    w++;
  }
  const res = Array.from(col);
  return res;
};

const result = distinctValues([1, 2, 1, 3, 1, 4]);
console.log(result);
