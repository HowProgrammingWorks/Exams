// Find a difference of two dictionaries
'use strict';

const dictDifference = (obj1, obj2) => {
  for (const key in obj2) {
    obj1[key] = obj2[key];
    delete obj1[key];
  }
  return obj1;
};

const result = dictDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
