// Make nested array planeArray
'use strict';

function planeArray(array) {
  const result = [];
  const length = array.length;
  for (let i = 0; i < length; i++) {
    const value = array[i];
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
