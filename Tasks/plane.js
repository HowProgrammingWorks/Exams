'use strict';

// Make nested array plane

const plane = (arr) => {
  let res = [];
  for (let value of arr) {
    const par = Array.isArray(value)
      ? plane(value)
      : [value]; 
    res.push(...par);
  }
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
