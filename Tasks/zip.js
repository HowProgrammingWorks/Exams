// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]
'use strict';

const zip = (arr1, arr2) => {
  const result = [];
  for (let i = 0; i < arr1.length && i < arr2.length; i++) {
    const tempCell = [arr1[i], arr2[i];
    if (!tempCell[0]) arr2.length -= 1;
    result.push(tempCell);
  }
  return result;
};

require('../Tests/zip.js')(zip);
