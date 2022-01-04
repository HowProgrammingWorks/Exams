// Copy all values from dict except listed
'use strict';

const except = (dict, ...exceptions) => {
  const cleanDict = {};
  const keys = Object.keys(dict);
  for (const key of keys) {
    if (!exceptions.includes(key)) cleanDict[key] = dict[key];
  }
  return cleanDict;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
