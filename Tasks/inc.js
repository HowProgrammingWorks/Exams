// Increment all numbers in dictionary
'use strict';
const incNumbers = (dict) => {
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (typeof dict[key] === 'number') dict[key]++;
  }
  return dict;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
