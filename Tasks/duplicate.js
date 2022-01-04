// Push single value multiple times

'use strict';

const duplicate = (value, N) => {
  if (N <= 0) return [];
  else {
    let res = [];
    for (let i = 0; i < N; i++) {
      res[i] = value;
    }
    return res;
  }
};

const result = duplicate('abc', 5);
console.log(result);
