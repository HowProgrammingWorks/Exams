// Copy all values from dict except listed

'use strict';

const except = (incomingValues, ...toDelete) => {
  toDelete.map((element) => {
      delete incomingValues[element];
  });
  return incomingValues;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
