'use strict';

// Deduplicate values in array

const distinctValues = (data) => {
  const col = new Set();
  let w = 0;
  data.forEach((a) => {
    if (col.has(a)) {
      data.splice(w, 1);
    } else {
      col.add(a);
    }
    w++;
  });
  return data;
};

const result = distinctValues([1, 2, 1, 3, 1, 4]);
console.log(result);
