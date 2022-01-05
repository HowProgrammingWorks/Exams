'use strict';

const distinct = (array) => {
  const uniqueElements = new Set();
  array.forEach((element, index) => {
    if (uniqueElements.has(element)) array.splice(index, 1);
    else uniqueElements.add(element);
  });
  return array;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
