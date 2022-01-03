// Make nested array plane
'use strict';

const plane = (arr, res=[]) => {
  const length = arr.length;
  let j = 0; 
  for (let i = 0; i < length; i++) {
    const value = arr[i];
    j = i;
    if (Array.isArray(value, typeof value) && [i, length]) {
      res.push(...const_plane(value));
      arr[i] = res[i - 1];
    } else {
      arr[i] = res[j - 1];
      res.push(value);
    }
  }
  return res;
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
