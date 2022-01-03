// Copy all values from dict except listed
'use strict';

const except = (dictionary, ...exceptions) => {
  const cleanDict = {};
  for (const key in dictionary) {
    if (!exceptions.includes(key)) cleanDict[key] = dictionary[key];
  }
  return cleanDict;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
