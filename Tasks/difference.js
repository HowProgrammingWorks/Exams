'use strict';

// Finde a difference of two dictionaries

const difference = (object1, object2) => {
  const diffDict = Object.assign({}, object1);
  for (const key in object2) {
    delete diffDict[key];
  }
  return diffDict;
};

const result = difference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
