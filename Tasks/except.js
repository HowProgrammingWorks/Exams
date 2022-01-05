// Copy all values from dict except listed

// Fixes:
// - not changing incoming parameters
// - improved code style
// - used for...of instead of .map

'use strict';

const except = (incomingValues, ...toDelete) => {
  const keys = Object.keys(incomingValues);
  const result = {};
  for (const key of keys) {
    if (!toDelete.includes(key)) {
      result[key] = incomingValues[key];
    }
  }
  return result;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
