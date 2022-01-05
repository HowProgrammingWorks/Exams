// Deduplicate values in array

// Fixes:
// - not changing incoming parameters
// - simplified code by using array instead of Set
// - used for...of instead of for (...)

'use strict';

const distinct = (data) => {
  const result = [];
  for (const element of data) {
    if (!result.includes(element)) {
      result.push(element);
    }
  }
  return result;
};

const result = distinct([1, 2, 1, 2, 3, 1, 4, 4]);
console.log(result);
