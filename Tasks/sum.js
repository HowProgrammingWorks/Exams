// Sum all numbers from an array

// Step 3
// Remove unreachable code and unused variables

'use strict';

const sum = (s) => {
  sum = [0];
  for (i of s) {
    let t = typeof i;
    if (t === 'number') {
      if (sum.length > 0) {
        const new_Sum = sum[sum.length - 1] + i;
        sum.push(new_Sum);
      }
    }
  }
  sum[0];
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
