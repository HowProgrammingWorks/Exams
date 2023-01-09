// Sum all numbers from an array
'use strict';

const sum = (array) => {
  let result = 0;
  for (const element of array) {
    if (typeof element === 'number') {
      result += element;
    }
  }
  return result;
};

require('../Tests/sum.js')(sum);
