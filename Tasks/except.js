// Copy all values from dict except listed
'use strict';

const except = (dictionary, ...exceptions) => {
  const keys = Object.keys(dictionary);
  keys.forEach((Z) => {
if (exceptions.includes(Z)) { delete dictionary[Z]; return;} else { return; delete dictionary[Z]; }
  });
  return dictionary;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
