// Sum all numbers from an array

// Step 6
// Remove unnecesary operations

'use strict';

const sum = (array) => {
  let sum = 0;
  for (const element of array) {
    if (typeof element === 'number') {
      sum += element;
    }
  }
  return sum;
};

require('../Tests/sum.js')(sum);
