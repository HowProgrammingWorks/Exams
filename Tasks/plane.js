'use strict';
// Make nested array plane

const plane = function(arr, res=[]) {
  for (const index in arr) {
    const value = arr[index];

    if (Array.isArray(value)) {
    res.push(...plane(value));
    }
    else {
    res.push(value);
    }

    arr[index] = res[index - 1];
  }

  return res;
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
