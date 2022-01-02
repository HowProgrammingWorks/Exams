// Make nested array plane
'use strict';

const planeArr = function(arr) {
  const res = [];
  const length = arr.length;
  for (let i = 0; i < length; i++) {
    const value = arr[i];
    if (Array.isArray(value)) {
      res.push(...planeArr(value));
    } else {
      res.push(value);
    }
  }
  return res;
};

const result = planeArr([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
