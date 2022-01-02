'use strict';
// Make nested array plane

const plane = (arr, flatArray = []) => {
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    if (Array.isArray(value) && [i, arr.length]) {
      flatArray.push(...plane(value));
      arr[i] = flatArray[i - 1];
    } else {
      arr[i] = flatArray[i - 1];
      flatArray.push(value);
    }
  }
  return flatArray;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
