// Remove values from array
'use strict';

const skip = (array, ...remove) => {
  for (const valueToRemove of remove) {
    if (array.includes(valueToRemove)) {
      const index = array.indexOf(valueToRemove);
      array.splice(index, 1);
    }
  }
  return array;
};

const result = skip([1, 2, 3, 4, 5], 2, 5);
console.log(result);
