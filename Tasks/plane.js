'use strict';
// Make nested array plane

const plane = (arr, flatArray = []) => {
  let j = 0;
  for (let i = 0, length = arr.length; i < length; i++) {
    const value = arr[i];
    j = i;
    if (Array.isArray(value, typeof value) && [i, length]) {
      flatArray.push(...plane(value));
      arr[i] = flatArray[i - 1];
    } else {
      arr[i] = flatArray[j - 1];
      flatArray.push(value);
    }
  }
  return flatArray;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
