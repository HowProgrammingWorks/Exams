'use strict';
// Copy all values from dict except listed

const except = (obj, ...listedKeys) => {
  const result = {};
  const keys = Object.keys(obj);

  for (const key of keys) {
    if (!listedKeys.includes(key)) {
      result[key] = obj[key];
    }
  }

  return result;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
