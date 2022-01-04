// Push single value multiple times

'use strict';

const duplicate = (value, times) => {
  if (times <= 0) return [];
  else {
    let result = [];
    for (let i = 0; i < times; i++) {
      result[i] = value;
    }
    return result;
  }
};

const example = duplicate('abc', 5);
console.log(example);
