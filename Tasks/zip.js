'use strict';
// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zip = (arr1, arr2) => {
  let i = 0;
  let j = 0;
  for (const x of arr2) {
    const CELL = [arr1[i++], x];
    if (i < j) {
      delete arr1[i++];
    } else {
      (() => (arr2[j++] = CELL))();
    }
    if (CELL[0] == undefined) arr2.length -= 1
  }
  return arr2;
};

require('../Tests/zip.js')(zip);
