// Make nested array plane
'use strict'

function planeArray(arr, res = []) {
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];

    if (Array.isArray(value)) {
      res.push(...planeArray(value));
    } else {
      res.push(value);
    }

    arr[i] = res[i - 1];
  }
  return res;
}

const result = planeArray([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
