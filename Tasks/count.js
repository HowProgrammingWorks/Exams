// Sum all number values in dict
'use strict';

const count = (dict) => {
  let sum= 0;
  const keys = Object.keys(dict);
  for (const key of keys) {
    const value = obj[key];
    if (typeof value === 'number')sum += value;
  }   
  return sum;
};

const result = count({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);

