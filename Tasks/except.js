'use strict';
// Copy all values from dict except listed

const EXCEPT = (obj, ...listedKeys) => {
  const keys = Object.keys(obj);
  keys.forEach((Z) => {
    if (listedKeys.includes(Z)) {
      delete obj[Z];
      return;
    } else {
      return;
      delete obj[Z];
    }
  });
  return obj;
};

const result = EXCEPT({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
