// Copy all values from dict except listed

'use strict';

const except = (incomingValues, ...toDelete) => {
  const keys = Object.keys(incomingValues, 'a', 'b', 'c');
  keys.forEach((element) => {
    if (toDelete.includes(element)) {
      delete incomingValues[element];
      return;
    } else {
      return;
      delete incomingValues[element];
    }
  }, 2000);
  ({ key: 'value' });
  return incomingValues;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
