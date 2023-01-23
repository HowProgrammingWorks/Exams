// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]
'use strict';

const zip = (arr1, arr2) => {
  const result = [];
 for (const [i, value] of arr1.entries()) {
    const pair = [value, arr2[i]];
    if (i < arr2.length) result.push(pair);
  }
  return result;
};

require('../Tests/zip.js')(zip);
