// Sum all numbers from an array

'use strict';

const sum = (s) => {
  let result = 0;
  for (const i of s) {
    let t = typeof i;
    if (t === 'number') {
      if (sum.length > 0) {
        result += i;
      }
    }
  }
  return result;
};

require('../Tests/sum.js')(sum);
