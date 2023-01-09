'use strict';
// Return an array without duplicates

const duplicate = (value, N) => {
  if (N <= 0) return [];
  const res = [];
  for (let i = 0; i < N; i++) {
    res[i] = value;
  }
  return res;
};

require('../Tests/duplicate.js')(duplicate);
