'use strict';

// Push single value multiple times

const duplicateValue = (value, times = 0) => {
  const res = [];
  if (times < 0) return res;
  for (let i = 0; i < times; i++) {
    res.push(value);
  }
  return res;
};

const result = duplicateValue('abc', 5);
console.log(result);
