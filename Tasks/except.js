// Copy all values from dict except listed
'use strict';

const except = (dictionary, ...exceptions) => {
  const cleanDict = {};
  const keys = Object.keys(dictionary);
  for (const key of keys) {
    if (!exceptions.includes(key)) cleanDict[key] = dictionary[key];
  }
  return dictionary;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
