// Sum all number values in dict
'use strict';

const sumNumbersInDict = (dict) => {
  let sum = 0;
  const keys = Object.keys(dict);
  for (const key of keys) {
    const value = dict[key];
    if (typeof value === 'number') sum += value;
  }
  return sum;
};

const result = sumNumbersInDict({ a: 1, b: 'two', c: 3, d: 4 });
console.log(result);
