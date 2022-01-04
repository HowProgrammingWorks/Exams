'use strict';

// Deduplicate values in array

const distinctValues = (data) => {
  const col = new Set();
  for (const item of data) col.add(item);
  const res = Array.from(col);
  return res;
};

const result = distinctValues([1, 2, 1, 3, 1, 4]);
console.log(result);
