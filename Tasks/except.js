'use strict'

// Copy all values from dict except listed

const except = (obj, ...args) => {
  const res = {};
  const keys = Object.keys(obj);
  for (const key of keys) {
    if (!args.includes(key)) {
      res[key] = obj[key];
    }
  }
  return res;
}

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
