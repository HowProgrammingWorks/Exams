// Make nested array plane
'use strict';

function plane(array) {
  const result = [];
  const length = array.length;
  for (let i = 0; i < length; i++) {
    const value = array[i];
    if (Array.isArray(value)) {
      result.push(...plane(value));
    } else {
      result.push(value);
    }
  }
  return result;
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
