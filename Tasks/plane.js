'use strict';

// Make nested array plane

const plane = array => {
  const res = [];
  for (const element of array) {
    if (Array.isArray(element)) {
      res.push(...plane(element));
    } else {
      res.push(element);
    }
  }
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
