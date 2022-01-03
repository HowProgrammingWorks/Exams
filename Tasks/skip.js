'use strict';

// Remove values from array

const skip = (array, ...charsToRemove) => {
  let removedChar = 0;
  for (const selectedChars of array) {
    for (const selectedCharsToRemove of charsToRemove) {
      if (selectedChars === selectedCharsToRemove) {
        array.splice(removedChar, 1);
      }
    }
    removedChar++;
  }
  return array;
};

const result = skip([1, 2, 3, 4, 5], 2, 5);
console.log(result);
