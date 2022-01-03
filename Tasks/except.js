// Copy all values from dict except listed
'use strict';

const except = (dictionary, ...exceptions) => {
  const keys = Object.keys(dictionary);
  keys.forEach(key => {
    if (exceptions.includes(key)) delete dictionary[key];
  });
  return dictionary;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
