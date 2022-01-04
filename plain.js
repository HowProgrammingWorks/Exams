'use strict';

// Make nested array plane

const arrPlain = (arr) => {
  const res = [];
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    if (Array.isArray(value)) {
      res.push(...arrPlain(value));
    } else {
      res.push(value);
    }
  }
  return res
};

const result = arrPlain([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
