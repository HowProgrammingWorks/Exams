'use strict';
// Make nested array plane

const plane = (arr, flatArray = []) => {
  for (let i = 0; i < arr.length; i++) {
    const value = arr[i];
    if (Array.isArray(value)) {
      flatArray.push(...plane(value));
    } else {
      flatArray.push(value);
    }
    arr[i] = flatArray[i - 1];
  }
  return flatArray;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
