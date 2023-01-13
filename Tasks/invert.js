// Reverse an array, you can't use .reverse()
'use strict';

const invert = (arr) => {
  const arrLength = arr.length;
  const invertedArr = new Array(arrLength);

  let newIndex = arrLength - 1;
  for (let index = 0; index < arrLength; index++)
    invertedArr[index] = arr[newIndex--];

  return invertedArr;
};

require('../Tests/invert.js')(invert);
