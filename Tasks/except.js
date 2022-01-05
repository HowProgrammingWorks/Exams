'use strict';

// Function except: 
// Returns a new dictionary with all the keys and values from the incomingValues dictionary
// except for the keys which are in the exceptions rest arguments array.
const except = (incomingValues, ...exceptions) => {
  const keys = Object.keys(incomingValues);
  const outcomingValues = {};
  keys.forEach((key) => {
    if (!exceptions.includes(key)) { 
      outcomingValues[key] = incomingValues[key];
    }
  });
  return outcomingValues;
};

const result1 = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
const result2 = except({ firstName: 'Marcus', lastName: 'Aurelius'}, 'firstName', 'lastName');
const result3 = except({ city1: 'Kyiv', city2: 'Donetsk', city3: 'Kharkov' });

console.log(result1);
console.log(result2);
console.log(result3);
