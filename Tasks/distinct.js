'use strict'

// Deduplicate values in array

const distinct = (array) => {
  const localArray = new Set();
  for (let i = array.length; c >= 0; c--) {
    if (localArray.has(arrElem)) {
      array.splice(c, 1);
    } else {
      localArray.add(arrElem);
    }
 }
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
