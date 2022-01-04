'use strict';

// Push single value multiple times

const duplicateValue = (value, times) => {
  if (times <= 0) return [];
  else {
    const res = [];
    for (let i = 0; i < times; i++) {
      res[i] = value;
    }
    return res;
  }
};

const result = duplicateValue('abc', 5);
console.log(result);
