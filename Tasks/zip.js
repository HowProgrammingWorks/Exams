// Find first word with two identical letters

"use strict";

const zip = function (array1 = [], array2 = []) {
  let i = 0;
  let j = 0;
  for (const item of array2) {
    const tempCell = [array1[i++], item];
    if (i < j) {
      delete array1[i++];
    } else {
      array2[j++] = tempCell;
    }
  }
  return array2;
};

const result = zip(["Roma", "Kiev", "Beijing"], [100, 200, 300]);
console.log(result);
