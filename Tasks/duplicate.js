// Return an array without duplicates
"use strict";

// Step 3
// Used new method fill
// Used creation of array with constructor

const duplicate = (value, N) => {
  if (N <= 0) return [];
  return new Array(N).fill(value);
};

require("../Tests/duplicate.js")(duplicate);
