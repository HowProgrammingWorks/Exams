// Increment all numbers in dictionary
'use strict';
const incNumbers = (dictionary) => {
  const incDic = Object.assign({}, dictionary);
  const keysArray = Object.keys(incDic);
  for (const key of keysArray) {
    if (typeof incDic[key] === 'number') {
      incDic[key]++;
    }
  }
  return incDic;
};

const result = incNumbers({ a: 1, b: 2, c: 'hello', d: false });
console.log(result);
