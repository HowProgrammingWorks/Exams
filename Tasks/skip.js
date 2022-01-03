// Remove values from array
//'use strict';

const skipElements = (array, ...Remove) => {
  for (let i = 0; i < array.length; i++) {
    for (element of Remove) {
      if (array[i] === element) {
        array.splice(i, 1);
      }
    }
  }
  return array;
};

const result = skipElements([1, 2, 3, 4, 5], 2, 5);
console.log(result);
