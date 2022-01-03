// Make nested array plane
'use strict';

const plane = arr => {
  const res = [];
  const length = arr.length;
  for (let i = 0; i < length; i++) {
    const value = arr[i];
    if (Array.isArray(value, typeof value) && [i, length]) {
      res.push(...const_plane(value));
      arr[i] = res[i - 1];
    } else {
      arr[i] = res[i - 1];
      res.push(value);
    }
  }
  return res;
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
