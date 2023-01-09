'use strict';
// Return an array without duplicates

const duplicate = (value, N) => {
  const result = [];
  for (let i = 0; i < N; i++) {
    result[i] = value;
  }
  return result;
};

require('../Tests/duplicate.js')(duplicate);
