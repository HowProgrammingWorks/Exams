// Sum all numbers from an array

'use strict';

const sum = (s) => {
  let result = 0;
  for (const i of s) {
    if (typeof i === 'number') {
      result += i;
    }
  }
  return result;
};

require('../Tests/sum.js')(sum);
