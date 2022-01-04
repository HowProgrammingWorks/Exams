// Make nested array planeArray
'use strict';

const planeArray = (array) => {
  const result = [];
  for (let value of array) {
    if (Array.isArray(value)) {
      result.push(...planeArray(value));
    } else {
      result.push(value);
    }
  }
  return result;
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
