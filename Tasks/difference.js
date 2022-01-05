// Finde a difference of two dictionaries

'use strict';
const difference = (obj1, obj2) => {
  const keysOfFirst = Object.keys(obj1);
  const res={};
  for (const key of keysOfFirst) {
    if (obj1[key] !== obj2[key]) {
      res[key] = obj1[key];
    }
  }
  return res;
};
const result = difference({a: 'uno', b: 'due'}, {a: 'uno', c: 'tre'});
console.log(result);
