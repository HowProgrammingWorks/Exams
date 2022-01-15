"use strict";

// Return an array without duplicates

const duplicate = (value, n) => {
  const res = [];
  for (let i = 0; i < n; i++) {
    res[i] = value;
  }
  return res;
};

const result = duplicate("abc", 5);
console.log(result);
