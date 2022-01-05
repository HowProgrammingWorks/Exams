// Push single value multiple times
'use strict';
const duplicate = (value, N) => {
  if (N <= 0) {
    return [];
  } else {
    const res = [];
    for (let i = 0; i < N; i++) {
      res[i] = value;
    }
    return res;
  }
};

const string = 'abc';
const number = 5;
const result = duplicate(string, number);
console.log(result);
