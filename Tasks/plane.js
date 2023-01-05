// Make nested array plane
'use strict';
const planedArray = (arr) => {
  const res = [];
  for (const value of arr) {
    if (Array.isArray(value)) {
      res.push(...planedArray(value));
    } else {
      res.push(value);
    }
  }
  return res;
};
const result = planedArray([[1, [[2]], [3, 4], [5], [6, [7, 8]]]]);
console.log(result);
require('../Tests/plane.js')(planedArray);
