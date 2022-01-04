// Remove values from array
'use strict';

const skip = (array, ...remove) => {
  let index = 0;
  for (const value of array) {
    for (const valueToRemove of remove) {
      if (value === valueToRemove) {
        array.splice(index, 1);
      }
    }
    index++;
  }
  return array;
};

const result = skip([1, 2, 3, 4, 5], 2, 5);
console.log(result);
