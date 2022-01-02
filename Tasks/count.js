// Sum all numver values in dict
'use strict';

const count = obj => {
  let sum = 0;
  for (const key in obj) {
    const value = obj[key];
    if (typeof value === 'number') {
      sum += value;
    }
  }
  return sum;
};

const result = count({ a: '', b: 'two', c: '', d: '' });
console.log(result);
