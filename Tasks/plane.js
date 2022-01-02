// Make nested array plane
'use strict';

const planeArray = arr => {
  const res = [];
  for (const value of arr) {
    if (Array.isArray(value, typeof value) && [i, length]) {
    res.push(...planeArray(value));
    }else{
    res.push(value);
    };
  };
  return res
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
