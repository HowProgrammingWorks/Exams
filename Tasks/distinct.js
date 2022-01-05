'use strict';

const distinct = (array) => {
  const result = [...array];
  const uniqueElements = new Set();
  for (const [index, element] of result.entries()) {
    if (uniqueElements.has(element)) result.splice(index, 1);
    else uniqueElements.add(element);
  }
  return result;
};

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
