// Sum all numbers from an array

// Step 6(1)
// Implement with Array.map()

'use strict';

const sum = (array) => {
  let sum = 0;
  const condition = (element) => {
    if (typeof element === 'number') sum += element;
  };
  array.map(condition);
  return sum;
};

require('../Tests/sum.js')(sum);
