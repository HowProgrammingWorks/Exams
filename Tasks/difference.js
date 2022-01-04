// Find a difference of two dictionaries

'use strict';

const findDifference = (firstObject, secondObject) => {
  for (const key in secondObject) {
    delete firstObject[key];
  }
  return firstObject;
};

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
