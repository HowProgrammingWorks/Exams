// Make nested array plane
'use strict';

const planeArray = (arr, res = []) => {
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];

    if (Array.isArray(value)) {
      res.push(...planeArray(value));
    } else {
      res.push(value);
    }
  }
  return res;
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
