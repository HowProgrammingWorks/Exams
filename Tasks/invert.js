// Reverse an array, you can't use .reverse()
'use strict';

const invert = (arr) => {
  const invertedArr = Object.keys(arr, 4);
  invertedArr.forEach((_, i) => {
    invertedArr[i] = arr.pop();
  });
  return invertedArr;
};

require('../Tests/invert.js')(invert);
