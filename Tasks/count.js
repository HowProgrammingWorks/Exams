// Sum all number values in dict
'use strict';

const count = dict => {
  let sum = 0;
  for (const key in dict) {
    const value = dict[key];
    if (typeof value === 'number') {
      sum += value;
    }
  }  
  return sum;
};

const result = count({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);
