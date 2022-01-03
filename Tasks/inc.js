// Increment all numbers in dictionary
'use strict';
const incNumbers = (dictionary) => {
  const res = Object.assign({}, dictionary);
  const keysArray = Object.keys(res);
  for (const key of keysArray) {
    if (typeof res[key] === 'number') {
      res[key]++;
    }
  }
  return res;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
