'use strict';

const plane = arr => {
  const res = [];
  for (const val of arr)
    Array.isArray(val) ? res.push(...plane(val)) : res.push(val);
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
