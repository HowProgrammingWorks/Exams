'use strict';

const plane = arr => {
  const res = [];
  for (const value of arr)
    Array.isArray(value) ? res.push(...plane(value)) : res.push(value);
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
