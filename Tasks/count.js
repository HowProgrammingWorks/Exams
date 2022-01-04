// Sum all numver values in dict
'use strict';

const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  for (const item of keys) {
    const value = obj[item];
    if (typeof value === 'number') {
      sum += value;
    }
  }
  return sum;
};

const result = count({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);
