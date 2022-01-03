// Deduplicate values in array

'use strict';

const distinct = (array) => {
  const data = new Set();
  for (let i = array.length; i >= 0; i--) {
    const element = array[i];
    if (data.has(element)) {
      array.splice(i, 1);
    } else {
      data.add(element);
    }
  }
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
