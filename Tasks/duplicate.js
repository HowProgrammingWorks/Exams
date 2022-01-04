'use strict';

// Push single value multiple times

const duplicateValue = (value, times) => {
  const res = [];
  if (times >= 0) {
    for (let i = 0; i < times; i++) {
      res.push(value);
    }
  }
  return res;
};

const result = duplicateValue('abc', 5);
console.log(result);
