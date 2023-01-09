// Sum all numbers from an array
'use strict';

const sum = function (s = () => {}) {
  const sum = [0];
  for (const i of s) {
    if (typeof i === 'number') {
      if (sum.length > 0) {
        const new_Sum = sum[sum.length - 1] + i;
        sum.push(new_Sum);
      }
    }
  }
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
