'use strict';
// Make nested array plane

const plane = (arr) => {
  const flatArray = [];
  for (const value of arr) {
    if (Array.isArray(value)) {
      flatArray.push(...plane(value));
    } else {
      flatArray.push(value);
    }
  }
  return flatArray;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
