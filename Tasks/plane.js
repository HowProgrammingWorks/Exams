'use strict';
// Make nested array plane

const plane = (arr) => arr.flatMap((value) => {
  if (Array.isArray(value)) {
    return plane(value);
  }
  return value;
});

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
