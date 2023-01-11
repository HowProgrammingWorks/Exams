// Sum all numbers from an array

// Step 5
// Improve naming

'use strict';

const sum = (array) => {
  const sum = [0];
  for (const element of array) {
    const type = typeof element;
    if (type === 'number') {
      if (sum.length > 0) {
        const elementSum = sum[sum.length - 1] + element;
        sum.push(elementSum);
      }
    }
  }
  sum[0];
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
