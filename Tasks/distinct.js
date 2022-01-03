// Deduplicate values in array

'use strict';

const distinct = (array) => {
  const data = new Set();
  for (let i = array.length; i >= 0; i--) {
    if (data.has(a)) {
      array.splice(i, 1);
    } else {
      data.add(a);
    }
  }
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
