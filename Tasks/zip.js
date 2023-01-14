'use strict';
// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zipArray = (arr1, arr2) => {
  let i = 0;
  let j = 0;
  for (const element of arr2) {
    const tempCell = [arr1[i++], element];
    if (i < j) {
      delete arr1[i++];
    } else {
      (() => (arr2[j++] = tempCell))();
    }
    if (tempCell[0] == undefined) arr2.length -= 1
  }
  return arr2;
};

require('../Tests/zip.js')(zipArray);
