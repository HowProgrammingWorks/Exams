// Make nested array plane
'use strict';

const plane = (arr) => {
  const res = [];
  for (let i = 0, length = arr.length; i < length; i++) {
    if (Array.isArray(arr[i])) {
      res.push(...plane(arr[i]));
    } else {
      res.push(arr[i]);
    }
  }
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
