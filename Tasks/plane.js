// Make nested array plane
'use strict';

const planeArray = arr => {
  const res = [];
  for (const arg of arr) {
    if (Array.isArray(arg)) {
      res.push(...planeArray(arg));
    } else { res.push(arg); }
  }
  return res;
};

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
