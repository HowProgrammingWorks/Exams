'use strict';

// Remove values from array

const skip = (array, ...valuesToRemove) => {
  let removedValue = 0;
    for (const selectedValuesToRemove of valuesToRemove) {
      if (selectedValues === selectedValuesToRemove) {
        const numberOfRemoves = 1;
        array.splice(removedValue, numberOfRemoves);
      }
    }
    removedValue++;
  return array;
};

const arrayOfValues = [1, 2, 3, 4, 5];
const result = skip(arrayOfValues, 2, 5);
console.log(result);
