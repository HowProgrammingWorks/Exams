'use strict';
// Copy all values from dict except listed

const EXCEPT = (obj, ...listedKeys) => {
  listedKeys.forEach((el) => {
    delete obj[el];
  });
  return obj;
};

const result = EXCEPT({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
