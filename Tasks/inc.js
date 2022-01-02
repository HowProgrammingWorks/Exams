// Increment all numbers in dictionary
'use strict';
const incNumbers = (dict) => {
  for (const key in dict) {
    if (typeof dict[key] === 'number') dict[key]++;
  }
  return dict;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
