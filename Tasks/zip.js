'use strict';
// Zip two arrays, [1, 2] and [3, 4] -> [[1, 3], [2, 4]]

const zipArray = (arr1, arr2) => {
  let j = 0;
  const length = arr1.length > arr2.length ? arr2.length : arr1.length;
  const res = [];
  for (let i = 0; i < length; i++) {
    const tempCell = [arr1[i], arr2[i]];
    res.push(tempCell);
  }
  return arr2;
};

require('../Tests/zip.js')(zipArray);
