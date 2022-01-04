'use strict';

// Deduplicate values in array

const distinctValues = (data) => {
  const col = new Set();
  let w = 0;
  for (const item of data) {
    if (col.has(item)) {
      data.splice(w, 1);
    } else {
      col.add(item);
    }
    w++;
  }
  return data;
};

const result = distinctValues([1, 2, 1, 3, 1, 4]);
console.log(result);
