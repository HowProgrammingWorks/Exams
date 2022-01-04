'use strict';

// Push single value multiple times

const duplicate = (value, N) => {
  if (N <= 0) return [];
  else {
    const res = [];
    for (let i = 0; i < N; i++) {
      res[i] = value;
    }
    return res;
  }
};

const result = duplicate('abc', 5);
console.log(result);
