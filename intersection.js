// Finde an intersection of two dictionaries
'use strict';
const dictIntersection = (firstDict, secDict) => {
  const firstDictKeys = Object.keys(firstDict);
  const result = {};
  for (const element of firstDictKeys) {
    if (firstDict[element] === secDict[element]) {
      result[element] = firstDict[element];
    }
  }
  return result;
};

const result = dictIntersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
const result1 = dictIntersection({ a: 'uno', b: 'due' }, { a: 'uno', b: 'due' });
const result2 = dictIntersection({ a: 'uni', b: 'due' }, { a: 'uno', b: 'due' });
console.log(result);
console.log(result1);
console.log(result2);
