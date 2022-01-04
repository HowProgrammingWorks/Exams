// Find first word with two identical letters

"use strict";

const zip = (...arrays) => {
  const result = [];
  const biggerLength = arrays.reduce((prev, curr) => Math.max(prev, curr.length), arrays[0].length);
  for(let i = 0; i < biggerLength; i++)
    result.push(arrays.map((arr) => (arr[i])));
  return result;
};

const result = zip(["Roma", "Kiev", "Beijing"], [100, 200, 300]);
console.log(result);
