'use strict';

// Function except: 
// Returns a new dictionary with all the keys and values from the incomingValues dictionary
// except for the keys which are in the exceptions rest arguments array.
const except = (incomingValues, ...exceptions) => {
  const KEYS = Object.keys(incomingValues);
  const outcomingValues = {};
  KEYS.forEach((key) => {
    if (!exceptions.includes(key)) { 
      outcomingValues[key] = incomingValues[key];
    }
  });
  return outcomingValues;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
