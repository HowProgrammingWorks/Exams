// Sum all numbers from an array
'use strict';

const sumNumbers = (array) => {
  let sum = 0;
  if (!Array.isArray(array)) {
    return 'It is not an array';
  }

  if (array.length === 0) {
    return 0;
  }
  
  for (let item of array) {
    if (typeof(item) === 'number') {
        sum += item; 
    }
  }
  
return sum;
};

require('../Tests/sum.js')(sumNumbers);
