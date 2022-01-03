'use strict';

// Make nested array plane

const plane = function(array) {
  const res = [];
  for (let i = 0, length = array.length; i < length; i++) {
    const element = array[i];
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
