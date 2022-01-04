// Remove values from array
'use strict';

const skipElements = (array, ...argFunction) => {
  let elementPos = 0;
  for (const arrElements of array) {
    for (const element of argFunction) {
      if (arrElements === element) {
        array.splice(elementPos, 1);
      }
    }
    elementPos++;
  }
  return array;
};

const result = skipElements([1, 2, 3, 4, 5], 2, 5);
console.log(result);
