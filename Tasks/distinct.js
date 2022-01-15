"use strict";

// Return an array without duplicates

const distinct = (array) => {
  return [...new Set(array)];
};

const array = [1, 2, 1, 3, 1, 4];
const result = distinct(array);
console.log("Result:", result);
console.log("Array:", array);
