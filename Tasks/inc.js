// Increment all numbers in dictionary
'use strict';
const incNumbers = dictionary => {
  for (const key in dictionary) {
    if (typeof dictionary[key] === 'number') {
      dictionary[key]++;
    }
  }
  return dictionary;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
