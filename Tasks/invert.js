// Reverse an array, you can't use .reverse()
'use strict';

const invert = (arr) => {
  const invertedArr = Object.keys(arr);
  for (let index = 0; index < invertedArr.length; index++){
    invertedArr[index] = arr.pop();
  };
  return invertedArr;
};

require('../Tests/invert.js')(invert);
