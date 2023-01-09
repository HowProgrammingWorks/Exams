// Sum all numbers from an array
'use strict';

const sumNumbers = (array) => {
  let sum = 0;
  for (let item of array) {
    if (typeof(item) === 'number') {
      if (sum.length > 0) {
        sum += item; 
      }
    }
  }
return sum;
};

require('../Tests/sum.js')(sumNumbers);
