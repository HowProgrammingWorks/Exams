"use strict";

// Return an array without duplicates

const distinct = (array) => {
  const set = new Set();
  array.forEach((element, index) => {
    if (set.has(element)) array.splice(index, 1);
    else set.add(element);
  });
  return array;
};

const array = [1, 2, 1, 3, 1, 4];
const result = distinct(array);
console.log("Result:", result);
console.log("Array:", array);
