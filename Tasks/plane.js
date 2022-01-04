'use strict';
// Make nested array plane

const planeArray = (array) => {
  const res = [];
  const keys = array.keys();
  for (const key of keys) {
    const value = array[key];
    if (Array.isArray(value)) {
      res.push(...planeArray(value));
    } else {
      res.push(value);
    }
  }
  return res;
};

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
