// Push single value multiple times

'use strict';

const duplicate = (value, times) => {
  if (times <= 0) {
    const end = new Error('Programm duplicate string 0 times!')
    return end;
  } else {
    const result = [];
    for (let i = 0; i < times; i++) {
      result[i] = value;
    }
    return result;
  }
};

const example = duplicate('abc', 0);
console.log(example);
