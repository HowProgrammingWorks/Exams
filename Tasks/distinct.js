'use strict';

const distinct = (array) => {
  const unicalElements = new Set();
  array.forEach((a, index) => {
    if (unicalElements.has(a)) {
      array.splice(index, 1);
    } else {
      unicalElements.add(a);
    }
  });
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
