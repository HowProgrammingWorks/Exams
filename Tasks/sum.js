// Sum all numbers from an array

'use strict';

const sumNumsFromArr = (arr) => {
  let result = 0;
  for (const item of arr) {
    if (typeof item === 'number') {
      result += item;
    }
  }
  return result;
};

require('../Tests/sum.js')(sumNumsFromArr);

// sum is fixed
// tests passed: 7 of 7
