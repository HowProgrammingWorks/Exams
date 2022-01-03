// Make nested array plane
'use strict';

const planeArray = array => {
  const res = [];
  for (const arg of array) {
    if (Array.isArray(arg)) {
      res.push(...planeArray(arg));
    } else { res.push(arg); }
  }
  return res;
};

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
