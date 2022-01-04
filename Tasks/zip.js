'use strict';
// Find first word with two identical letters

const zip = (arr1 = [], arr2 = []) => {
  const result = [];
  const minLength = Math.min(arr1.length, arr2.length);
  for (let i = 0; i < minLength; i++) {
    const pair = [arr1[i], arr2[i]];
    result.push(pair);
  }
  return result;
};

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
