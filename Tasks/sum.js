// Sum all numbers from an array

// Step 4
// Add `const` and `let`

'use strict';

const sum = (s) => {
  const sum = [0];
  for (const i of s) {
    const t = typeof i;
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
