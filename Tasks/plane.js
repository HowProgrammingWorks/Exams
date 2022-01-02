'use strict';
// Make nested array plane

const plane = function(arr, res=[]) {
  for (const index in arr) {
    const value = arr[index];
    const j = index

    if (Array.isArray(value, typeof value) && [index, length]) {
    res.push(...plane(value));
    arr[index] = res[index - 1]
    } else{
    arr[index] = res[j - 1]
    res.push(value);
    };
  };

  return res
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
