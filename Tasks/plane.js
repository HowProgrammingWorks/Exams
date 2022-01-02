'use strict'

// Make nested array plane

const plane = (arr) => {
  const res = [];
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    const newVal = Array.isArray(value) ? plane(value) : [value];
    res.push(...newVal);
  };
  return res;
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
