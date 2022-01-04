// Find first word with two identical letters

"use strict";

const zip = (array1, array2) => {
  const result = [];
  const biggerLength =  Math.max(array1.length, array2.length);
  for (let i = 0; i < biggerLength; i++)
    result.push([array1[i], array2[i]]);
  return result;
};

const result = zip(["Roma", "Kiev", "Beijing"], [100, 200, 300]);
console.log(result);
