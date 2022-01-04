'use strict';

// Remove values from array

const skip = (array, ...valuesToRemove) => {
  for (const selectedValuesToRemove of valuesToRemove) {
    const numberOfRemoves = 1;
    array.splice(array.indexOf(selectedValuesToRemove), numberOfRemoves);
  }
  return array;
};

const arrayOfValues = [1, 2, 3, 4, 5];
const result = skip(arrayOfValues, 2, 5);
console.log(result);
