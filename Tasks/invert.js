'use strict';
// Reverse an array, you can't use .reverse()

const invert = (arr) => {
  const arrLength = arr.length;
  const invertedArr = new Array(arrLength);

  let indexArr = arrLength - 1;
  for (let indexInvArr = 0; indexInvArr < arrLength; indexInvArr++)
    invertedArr[indexInvArr] = arr[indexArr--];

  return invertedArr;
};

require('../Tests/invert.js')(invert);
