'use strict';

// Remove values from array

const skip = (array, ...charsToRemove) => {
  let removedChar = 0;
  for (const selectedChars of array) {
    for (const selectedCharsToRemove of charsToRemove) {
      if (selectedChars === selectedCharsToRemove) {
        const numberOfRemoves = 1;
        array.splice(removedChar, numberOfRemoves);
      }
    }
    removedChar++;
  }
  return array;
};

const arrayOfChars = [1, 2, 3, 4, 5];
const result = skip(arrayOfChars, 2, 5);
console.log(result);
