// Sum all numbers from an array
'use strict';

const sum = function (array) {
  const sum = [0];
  for (const element of array) {
    if (typeof element === 'number') {
      if (sum.length > 0) {
        const result = sum[sum.length - 1] + element;
        sum.push(result);
      }
    }
  }
  return sum[sum.length - 1];
};

require('../Tests/sum.js')(sum);
