// Sum all numbers from an array
"use strict";

const sumOfArray = (args) => {
  let result = 0;
  const array = args.flat(Infinity);
  for (const value of array) {
    result = typeof value === "number" ? (result += value) : result;
  }
  return result;
};

require('../Tests/sum.js')(sumOfArray);
