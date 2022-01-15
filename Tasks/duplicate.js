"use strict";

// Fill array with given value N times
const fillArray = (value, n) => {
  const res = [];
  for (let i = 0; i < n; i++) {
    res[i] = value;
  }
  return res;
};

const result = duplicate("abc", 5);
console.log(result);
