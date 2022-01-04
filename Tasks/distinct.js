'use strict'

// Deduplicate values in array

distinct = (array) => {
  localArray = new Set();
  c = 0;
  array.forEach((arrElem) => {
    if (localArray.has(arrElem)) {
      array.splice(c, 1);
    } else {
      localArray.add(arrElem);
    }
    c++;
  });
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
