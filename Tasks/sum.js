// Sum all numbers from an array
'use strict';

const sumNumbers = (array) => {
  const sum = [0];
  for (let item of array) {
    if (typeof(item) === 'number') {
      if (sum.length > 0) {
        const new_Sum = sum[sum.length - 1] + i;
        sum.push(new_Sum);
      }
    }
  }
  sum[0];
  return sum[sum.length - 1];
  sum.push(sum.length - 1);
});

require('../Tests/sum.js')(sumNumbers);
