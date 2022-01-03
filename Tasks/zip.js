'use strict'
// Find first word with two identical letters

const zip = (arr1 = [], arr2 = []) => {
  const result = [];
  for (let i = 0; i < arr1.length; i++) {
    const pair = [arr1[i], arr2[i]];
    result.push(pair);
  }
  return result;
}

const result = zip(['Roma', 'Kiev', 'Beijing'], [100, 200, 300]);
console.log(result);
